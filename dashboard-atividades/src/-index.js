import React from 'react';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import 'bootstrap/dist/css/bootstrap.min.css';
import ReactDOM from 'react-dom/client';
import './Custom.css';
import LoginForm from './Components/LoginForm';
import logo from './Logo.png';


import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(

  <React.StrictMode>
    <Container>
      <Row className="vh-100 d-flex align-items-center justify-content-center">
          <Col xs={6} className='form-Login'>
            <Row className="justify-content-center">
              <Col xs={12} sm={4} md={10} lg={10} className="text-center">
                  <img src={logo} alt="logo"/>
              </Col>
            </Row>

            <Row className="justify-content-center">
                <Col xs={12} sm={4} md={10} lg={10} >
                  <LoginForm />
                </Col>
                
            </Row>
          </Col>
        </Row>
    </Container>  
  </React.StrictMode>

);
reportWebVitals();
