# Real-Time Data Processing System

This project demonstrates the integration of multiple technologies to create a real-time data processing system. It uses TypeScript and React for the frontend, VB.NET for backend processing, and Node.js with WebSocket technology for seamless server communication. This setup is ideal for applications requiring live data updates such as monitoring dashboards or real-time analytics.

## Project Overview

The system is designed to showcase real-time communication between a client application and a server, using WebSockets for data transmission. The frontend is built with React and TypeScript, offering a responsive UI that updates live data received through WebSocket connections. The backend, written in VB.NET, simulates data processing and sends updates to the frontend via a Node.js server.

### Key Features

- **Real-Time Communication**: Utilizes WebSockets for instant data push from the server to the client.
- **Cross-Technology Integration**: Combines the robustness of TypeScript, the versatility of VB.NET, and the efficiency of Node.js.
- **Dynamic Data Updates**: Demonstrates live updates, which can be adapted for real-time monitoring or activity tracking systems.

## Technologies Used

- **Frontend**: React (TypeScript)
- **Backend**: VB.NET
- **Server**: Node.js, Express.js, WebSocket

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- Node.js
- .NET Framework (for VB.NET)
- WebSocket4Net for VB.NET

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/satyasn01/Real-time-data.git
   cd Real-time-data
   ```

2. **Set up the Node.js WebSocket server**
   - Navigate to the server directory:
     ```bash
     cd server
     npm install
     node server.js
     ```

3. **Run the VB.NET Backend**
   - Open the VB.NET project in Visual Studio located under the `backend` folder.
   - Build and run the application.

4. **Launch the React Frontend**
   - Navigate back to the root directory and then to the client directory:
     ```bash
     cd ../client
     npm install
     npm start
     ```

## Usage

Once all components are running, the React application will display real-time data received from the VB.NET backend via the WebSocket server. This setup demonstrates how different technologies can work together in real-time data processing and display.

## Contributing

We welcome contributions to this project! If you have suggestions to improve this, please fork the repository and create a pull request. You can also open an issue with the tag "enhancement". Please follow the code of conduct in this project.

## Contributors

- **[satya]** - *Initial work* - [satyasn01](https://github.com/satyasn01)
- **Anjali** - *Contributed to various parts of the project* -

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.txt) file for details.

## Acknowledgments

- WebSocket4Net for providing WebSocket support in VB.NET
- Node.js community for the robust server-side platform
- React community for the powerful frontend library
