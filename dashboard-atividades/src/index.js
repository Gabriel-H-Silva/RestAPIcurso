import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import ReactDOM from 'react-dom/client';
import Sidebar from './Components/Sidebar';
import Content_teste from './Components/Content_teste';
import './Custom.css';


import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(

  <React.StrictMode>
    <Sidebar />
    <Content_teste/>
  </React.StrictMode>

);
reportWebVitals();

