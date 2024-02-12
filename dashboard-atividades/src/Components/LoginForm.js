
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
//import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';

function LoginForm() {
  return (

  <Form >

    <Form.Group className="mb-3" controlId="formBasicEmail">
      <Form.Label>Usuario</Form.Label>
      <Form.Control className='custom_Input' type="Usuario" placeholder="Usuario" />
    </Form.Group>

    <Form.Group className="mb-3" controlId="formBasicPassword">
      <Form.Label>Senha</Form.Label>
      <Form.Control type="password" className='custom_Input' placeholder="Senha" />
    </Form.Group>
    <div class="text-center">
      <Button variant="primary" type="submit" className='Custom_btn'>
        Login
      </Button>
    </div>
  </Form>

    
  );
}

export default LoginForm;
