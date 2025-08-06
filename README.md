The Driving and Vehicle License Department (DVLD) is a system to mangage everything related to driving licenses and drivers
This is a milestone project in the ProgrammingAdvices course roadmap.

<img width="1914" height="643" alt="image" src="https://github.com/user-attachments/assets/a5058c41-9022-4de6-bd49-28c97f43b4a2" />
<img width="1920" height="829" alt="image" src="https://github.com/user-attachments/assets/bd80e385-d42a-48cd-a8cf-46248a860610" />


## Key Features

- Manage people, users and drivers...etc, with the usual CRUD operations
- Manage local and internatinal driving license applications 
- Schedule driving tests (vision, theory and practical), with the ability to retake exams
- Issue Driving Licenses with different classes
- Renew driving licenses in case the validation period has ended
- Replace lost and damaged driving licenes
- Detain and release driving licenses
<img width="1920" height="919" alt="image" src="https://github.com/user-attachments/assets/06de6839-3e22-49fa-9744-0dcb95712a48" />


## Database

<img width="1672" height="1460" alt="DVLD_solution drawio" src="https://github.com/user-attachments/assets/e757a65d-fdd4-4d76-97c4-2ad95fb51bca" />

My database design contained many flaws and I learned a lot from this experience, I ended up using Mohammed Abu Hadhoud's database design for the project.

## Security

- I used the key derivation function PBKDF2 and stored the password hashes and salt as fields in the database
- but the project contains multiple security flaws, it is for learning purpouses so I didn't focus too much on it. 

## Things to improve

- [x] abstract away the data grid filtering logic into a control
- [ ] refactor the old filtering logic
- [x] add filtering to drivers managemet form
- [ ] improve the UI 
