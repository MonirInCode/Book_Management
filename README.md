# Book Management System

This project is a Book Management System designed to handle book entities and their management through a structured architecture including factories, managers, and repositories.

## Project Structure

### Entities

- **Book.cs**: Represents the core properties and behaviors of a book.
- **BookType.cs**: Defines different types of books within the system.

### Factory

The Factory classes are responsible for creating book instances based on specified types.

- **AcademicBookFactory.cs**: Factory class for creating academic book instances.
- **BaseBookFactory.cs**: The base factory class from which specific book factories inherit.
- **BookManagementFactory.cs**: Centralized factory for managing the creation of book types.
- **GeneralBookFactory.cs**: Factory class for creating general book instances.

### Manager

The Manager classes handle the business logic and operations associated with books.

- **AcademicBookManager.cs**: Manages operations for academic books.
- **GeneralBookManager.cs**: Manages operations for general books.
- **IBookManager.cs**: Interface for book managers to standardize book management operations.

### Repository

The Repository layer provides data access functionality for books.

- **BookRepository.cs**: Implements the methods for data storage and retrieval of book entities.
- **IBookRepository.cs**: Interface defining methods for accessing book data.

## Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/book-management.git
   cd book-management


![BookManagementScreenshot](https://github.com/user-attachments/assets/b28f325e-4f73-49b1-ae03-1655e361694b)




### Requirements
.NET or compatible framework
Basic understanding of object-oriented programming principles

### Contact
For questions or contributions, please reach out to monirgsc@gmail.com

