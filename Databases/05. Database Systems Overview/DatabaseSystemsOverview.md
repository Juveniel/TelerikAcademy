## Database Systems - Overview

1.  What database models do you know?
    - Relational 
    - NoSQL
    - In-memory

1.  Which are the main functions performed by a Relational Database Management System (RDBMS)?
    - Data Strorage
    - Data Transformation
    - Data Security
    - Multiuser Access Control 
    - Backup and Recovery
    - Transaction management

1.  Define what is "table" in database terms.
    - A table is a collection of related data held in a structured format within a database. It consists of columns, and rows.

1.  Explain the difference between a primary and a foreign key.
    - The primary key uniquely identifies a record in the table. It cannot accept null values.
    - The foreign key is a a field in the table that is primary key in another table. Can accept null values.

1.  Explain the different kinds of relationships between tables in relational databases.
    - One-to-Many Relationships - in this type of relationship, a row in table A can have many matching rows in table B, but a row in table B can have only one matching row in table A. 
    - Many-to-Many Relationships - a row in table A can have many matching rows in table B, and vice versa. 
    - One-to-One Relationships - a row in table A can have no more than one matching row in table B, and vice versa.

1.  When is a certain database schema normalized?
    - Database normalization, or simply normalization, is the process of organizing the columns (attributes) and tables (relations) of a relational database to reduce data redundancy and improve data integrity.

1.  What are database integrity constraints and when are they used?      
    - Key constraints - specify attributes or combinations of attributes which must be unique. 
    - Not Null constraints - no part of a primary key field can contain NUL.
    - Semantic integrity constraints - express general restrictions on the data and changes to it.

1.  Point out the pros and cons of using indexes in a database.
    - Indexes speed up select but slows down inserts, updates and deletes because the database engine does not have to write the data only, but the index, too. 

1.  What's the main purpose of the SQL language?
    - SQL is short for Structured Query Language. It is a standard programming language used in the management of data stored in a relational database management system. It supports distributed databases, offering users great flexibility.

1.  What are transactions used for?
    - Ensures that a set of operations have been completed successfully.         

1.  What is a NoSQL database?
    - A NoSQL (originally referring to "non SQL", "non relational" or "not only SQL") database provides a mechanism for storage and retrieval of data which is modeled in means other than the tabular relations used in relational databases. 

1.  Explain the classical non-relational data models.   
    - Key-value - stores use the associative array (also known as a map or dictionary) as their fundamental data model.
    - Document Store - the central concept of a document store is the notion of a "document"(xml, json).
    - Graph - this kind of database is designed for data whose relations are well represented as a graph consisting of elements interconnected with a finite number of relations between them.

1.  Give few examples of NoSQL databases and their pros and cons.
    - MongoDB - consistent, flexible, scalable, fast.
    - Cassandra - decentralized, scalable, elastic