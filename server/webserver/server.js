// server.js
const WebSocket = require('ws');
const express = require('express');
const app = express();
const server = require('http').createServer(app);
const wss = new WebSocket.Server({ server });

wss.on('connection', function connection(ws) {
  console.log('A client connected');
  ws.on('message', function incoming(message) {
    console.log('Received: %s', message);
  });

  setInterval(() => {
    ws.send('Message from server: ' + new Date().toISOString());
  }, 1000); // Send a message every second
});

server.listen(4000, () => {
  console.log('WebSocket server started on http://localhost:4000');
});
