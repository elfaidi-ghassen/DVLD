using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util
{

    /// <summary>
    /// This control use used to abstract away the repetitive code
    /// that deals with filtering data grid view control elements.
    /// </summary>
    public partial class FilterBox : UserControl
    {
        public delegate void ResetFilter();
        public ResetFilter OnResetFilter;

        public delegate void NumberFilterChanged(int n);
        public delegate void TextFilterChanged(string s);

        private Dictionary<string, NumberFilterChanged> numberFilters =
                    new Dictionary<string, NumberFilterChanged>();

        private Dictionary<string, TextFilterChanged> textFilters =
                    new Dictionary<string, TextFilterChanged>();
        public FilterBox()
        {
            InitializeComponent();
        }


        // ====================================================================
        // API
        public void AddResetFilterOption(ResetFilter fn) => OnResetFilter += fn;

        public void AddNumberFilterOption(string label, NumberFilterChanged fn)
        {
            filterCombo.Items.Add(label);
            numberFilters.Add(label, fn);
        }

        public void AddTextFilterOption(string label, TextFilterChanged fn)
        {
            filterCombo.Items.Add(label);
            textFilters.Add(label, fn);
        }


        // ====================================================================
        // Helpers

        /// <summary>
        /// Hides all the filtering input fields buy changing the visibility to false
        /// </summary>
        private void HideAllInputs()
        {
            filterTextBox.Visible = false;
            filterNumber.Visible = false;
            filterSubCombo.Visible = false;
        }

        private void OnFilterBoxLoad(object sender, EventArgs e)
        {
            HideAllInputs();
            filterCombo.Items.Add("All");
            filterCombo.SelectedIndex = 0;
        }

        private string SelectedFilterValue()
        {
            return filterCombo.Text;
        }


        /// <summary>
        /// Produce true if the given string option label 
        /// is associated with the filtering number input field
        /// </summary>
        private bool IsNumberFilterOption(string option)
        {
            return numberFilters.Keys.Contains(option); 
        }

        /// <summary>
        /// Produce true if the given string option label 
        /// is associated with the filtering text input field
        /// </summary>
        private bool IsTextFilterOption(string option)
        {
            return textFilters.Keys.Contains(option);
        }
        private bool FilterOnInitialState()
        {
            return filterCombo.SelectedIndex == 0;
        }
        
        private int NumberFilterValue() => (int)filterNumber.Value;
        private string TextFilterValue() => filterTextBox.Text;
        
        // ====================================================================
        // Event Handlers

        private void OnFilterComboSelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterOnInitialState())
            {
                HideAllInputs();
                OnResetFilter?.Invoke();
                return;
            } 
            if (IsNumberFilterOption(SelectedFilterValue()))
            {
                HideAllInputs();
                filterNumber.Visible = true;
            } else if (IsTextFilterOption(SelectedFilterValue()))
            {
                HideAllInputs();
                filterTextBox.Visible = true;
            }
            
        }

        private void OnFilterNumberValueChange(object sender, EventArgs e)
                    => numberFilters[SelectedFilterValue()]?.Invoke(NumberFilterValue());

        private void OnTextChangedFilterTextBox(object sender, EventArgs e)
        {
            textFilters[SelectedFilterValue()]?.Invoke(TextFilterValue());
            if (filterTextBox.Text == string.Empty)
                OnResetFilter?.Invoke();
        }
        
        /// <summary>
        /// Event Handler: when the user "unfocus" on the input field
        /// If the user leaves the number input field empty, it means
        /// we should call the Reset Handler.
        /// </summary>
        /// I expected `filterNumber.Value == null` to work, but it did not.
        private void OnValidatedFilterNumber(object sender, EventArgs e)
        {
            if (filterNumber.Text == string.Empty)
                OnResetFilter?.Invoke();
        }
    }
}
