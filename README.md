# Back-End Project

## Introduction

In the course project, a backend application was developed using the C# language, with an SQL server as the database. The main purpose is to enable communication between users.

## Data Models in Use

User:
- ID
- Password
- First Name
- Last Name
- Join Date
- Last Login Time

Message:
- Title
- Message
- Sender 
- Receiver
- Link to the previous message (if it's a reply in a thread)

All models have their own ID, which are used to identify and link them to each other.

## Features

The application offers the following main features:

- Messages:
  - Users can create and send both public and private messages.

- Message Threads:
  - Messages can form threads by replying to existing messages.

- Privacy:
  - Private messages are only visible to the receiver and the sender.

- Message Editing and Deletion:
  - Users can edit and delete their own messages.

- Profile Management:
  - Users can edit their own profile and delete it if necessary.

## Application Structure and Interfaces

The application follows the following structure:

- User Interface (UI):
  - The application can be accessed through a web interface.

- RESTful API:
  - The application can be used via tools like Postman, allowing users to perform various actions.
 
## Additional Features
  - The application does not have functionality for message notifications.
  - Files cannot be attached to messages.
  - The application is monolingual.
  - Statistics on application usage.
