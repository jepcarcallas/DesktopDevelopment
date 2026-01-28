# Contact Manager Application

A comprehensive Windows Forms contact management application built with .NET 8 and C# 12.

## Features

### User Interface
- **Menu Bar**: File, Edit, and Help menus
- **Toolbar**: Quick access buttons for Add, Edit, Delete, Save, and Open operations
- **Split View**: Left panel for contact list, right panel for contact details
- **Search Functionality**: Real-time search contacts by name or email
- **Tabbed Interface**: Organize information into Personal Info, Tasks, and Notes tabs

### Contact Management
- **Add New Contacts**: Create new contact entries with comprehensive information
- **Edit Contacts**: Modify existing contact information
- **Delete Contacts**: Remove contacts with confirmation
- **Search Contacts**: Filter contacts by name or email address
- **Profile Photos**: Add and change contact profile pictures

### Contact Information Fields
- **Profile Section**:
  - Profile photo
  - First name and last name
  - Email address (required field)

- **Contact Details**:
  - Phone number
  - Mobile number
  - Street address
  - City, State, ZIP code
  - Country

- **Additional Information**:
  - Company name
  - Job title
  - Department
  - Birthday (date picker)

- **Tasks and Notes**:
  - Tasks tab for task management
  - Notes tab for general notes

### Data Persistence
- **Save to File**: Export all contacts to JSON format
- **Load from File**: Import contacts from JSON files

### Sample Data
The application includes 6 pre-loaded sample contacts:
- Sarah Johnson - Software Engineer at Tech Solutions Inc.
- Michael Chen
- Emily Rodriguez
- David Thompson
- Jessica Williams
- Robert Martinez

## Usage

1. **Adding a Contact**:
   - Click the "Add" button in the toolbar
   - Fill in the contact information (Email is required)
   - Click "Save Changes"

2. **Editing a Contact**:
   - Select a contact from the list
   - Click the "Edit" button in the toolbar
   - Modify the information
   - Click "Save Changes" or "Cancel"

3. **Deleting a Contact**:
   - Select a contact from the list
   - Click the "Delete" button in the toolbar
   - Confirm the deletion

4. **Searching Contacts**:
   - Type in the search box at the top of the contact list
   - Results filter in real-time

5. **Saving/Loading Data**:
   - Click "Save" to export contacts to a JSON file
   - Click "Open" to import contacts from a JSON file

## Technical Details
- **Framework**: .NET 8
- **Language**: C# 12.0
- **UI Framework**: Windows Forms
- **Data Format**: JSON for import/export
- **Custom Drawing**: Owner-drawn ListBox with circular avatars and contact initials
