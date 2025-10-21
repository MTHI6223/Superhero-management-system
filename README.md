# Superhero Management System

A comprehensive Windows Forms application for managing superhero data with a three-layer architecture following software engineering best practices.

## Project Overview

This application implements a complete superhero management system with the following features:
- Add new superheroes with validation
- View all superheroes in a formatted grid
- Update existing superhero information
- Delete superheroes with confirmation
- Generate comprehensive summary reports

## Architecture

The application follows a three-layer architecture pattern:

### 1. Application Layer (Presentation)
- **Form1.cs**: Main Windows Forms interface
- Handles user interactions and displays data
- Delegates business logic to the Business Layer
- Provides user feedback and error messages

### 2. Business Layer (Logic/Domain)
- **SuperheroBusinessLogic.cs**: Core business logic and validation
- Implements data validation rules
- Calculates ranks and threat levels based on exam scores
- Handles business operations (add, update, delete, generate summary)
- Contains summary statistics calculations

### 3. Database Layer (Data Access)
- **SuperheroDataAccess.cs**: File operations and data persistence
- Manages superheroes.txt file operations
- Handles summary.txt file operations
- Provides error handling for file operations

## Features

### Adding New Superheroes
- Form validation for all required fields
- Age and exam score number validation
- Exam score range validation (0-100)
- Automatic rank and threat level calculation
- Data persistence to superheroes.txt

### Viewing Superheroes
- DataGridView display with all superhero information
- Formatted columns for easy reading
- Automatic refresh when data changes
- Real-time updates after operations

### Updating Superheroes
- Select superhero from grid for editing
- Form pre-population with existing data
- Validation and recalculation of ranks
- Data persistence with updated information

### Deleting Superheroes
- Selection-based deletion from grid
- Confirmation dialog for safety
- Data removal from file
- Grid refresh after deletion

### Summary Reports
- Comprehensive statistics calculation
- Total heroes count
- Average age and exam score
- Rank distribution (S, A, B, C ranks)
- Report generation and file saving

## Technical Implementation

### Validation Rules
- All fields must be filled
- Age must be a valid number
- Exam score must be a number between 0-100
- Clear error messages for invalid input

### Rank Calculation
- **S-Rank**: 81-100 (Threat: "Finals Week")
- **A-Rank**: 61-80 (Threat: "Midterm Madness")
- **B-Rank**: 41-60 (Threat: "Group Project Gone Wrong")
- **C-Rank**: 0-40 (Threat: "Pop Quiz")

### Error Handling
- File operation error handling
- Input validation with user feedback
- Exception handling across all layers
- Graceful error recovery

## File Structure

```
SuperheroApp/
├── SuperheroApp/
│   ├── BusinessLayer/
│   │   └── SuperheroBusinessLogic.cs
│   ├── DataLayer/
│   │   └── SuperheroDataAccess.cs
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   └── Properties/
└── SuperheroApp.sln
```

## Data Files

- **superheroes.txt**: Contains all superhero records (comma-separated)
- **summary.txt**: Contains generated summary reports

## Development

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later

### Building
```bash
dotnet build SuperheroApp.sln
```

### Running
```bash
dotnet run --project SuperheroApp
```

## Git History

The project includes comprehensive Git history with meaningful commits:
- Initial commit with layered architecture
- Feature commits for each major functionality
- Incremental development process
- Clear commit messages describing changes

## Requirements Compliance

This project fulfills all requirements from the Programming 2782 rubric:

### Application Layer Requirements
✅ Form correctly accepts input for all fields  
✅ Clear error messages for invalid input  
✅ DataGridView populated and formatted correctly  
✅ View refreshes when file is updated  
✅ Selected record loads into form for editing  
✅ DataGridView displays updated information  
✅ Selection and deletion with confirmation  
✅ DataGridView refreshes after deletion  
✅ Summary results displayed on form  
✅ Input validation and error messages  

### Business Layer Requirements
✅ Data validation for all fields  
✅ Successfully appends new records with calculations  
✅ Updated information validated and recalculated  
✅ Calculates summary statistics accurately  
✅ Error handling for file operations  

### Database Layer Requirements
✅ Successfully appends to superheroes.txt  
✅ Data read from superheroes.txt  
✅ Updated information saved to superheroes.txt  
✅ Records removed from superheroes.txt  
✅ Summary saved to summary.txt with formatting  
✅ Error handling for file operations  

### Development Requirements
✅ Git repository initialized  
✅ Meaningful commit messages for each feature  
✅ Clear commit history with incremental development  
✅ GitHub integration ready  

## Author

Developed as part of Programming 2782 coursework at Belgium Campus iTversity.

## License

This project is for educational purposes only.
