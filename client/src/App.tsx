// src/App.tsx
import React, { useEffect, useState } from 'react';

function App() {
  const [data, setData] = useState<string>('');

  useEffect(() => {
    const ws = new WebSocket('ws://localhost:4000'); // This assumes your WebSocket server will be on port 4000

    ws.onopen = () => {
      console.log('WebSocket Connected');
    };

    ws.onmessage = (event) => {
      setData(event.data.toString());
    };

    ws.onerror = (error) => {
      console.error('WebSocket Error: ', error);
    };

    return () => {
      ws.close();
    };
  }, []);

  return (
    <div className="App">
      <header className="App-header">
        <p>Real-time Data: {data}</p>
      </header>
    </div>
  );
}

export default App;
