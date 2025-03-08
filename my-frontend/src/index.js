import React from 'react';
import ReactDOM from 'react-dom/client';  // Make sure you're importing from 'react-dom/client'
import { Provider } from 'react-redux';
import store from './redux/store';
import App from './App';

// Use createRoot to initialize the app in React 18+
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <Provider store={store}>
    <App />
  </Provider>
);
