import { useState } from 'react';
import { Container, Row, Col,Nav, NavDropdown , Button, Offcanvas } from 'react-bootstrap';
import Navbar from 'react-bootstrap/Navbar';
import { MdMenu } from "react-icons/md";
import Logo from '../img/LogoWeb.jpg';

function Sidebar() {
  const [show, setShow] = useState(false);

  const handleShow = () => setShow(true);
  const handleClose = () => setShow(false);
  return (

    <Navbar expand="lg" className="bg-body-tertiary">
        <Container className='Custom_Container'>
            <Button onClick={handleShow}><MdMenu /></Button>
            <Navbar.Brand href="#home" className='Logo_style'>
                <img
                alt=""
                src={Logo}
                width="45"
                height="45"
                className="d-inline-block align-top"
                />
                Suporte IO
            </Navbar.Brand>

                <Navbar.Collapse className="justify-content-end">
                    <Navbar.Text>
                        Logado: <a href="#login">user</a>
                    </Navbar.Text>
                    
                </Navbar.Collapse>
            

            <Offcanvas show={show} onHide={handleClose}>
                <Offcanvas.Header closeButton>
                <Offcanvas.Title>Menus</Offcanvas.Title>
                </Offcanvas.Header>
                <Offcanvas.Body>

                    <Nav className="justify-content-end flex-grow-1 pe-3">

                        <Nav.Link href="#action1">Home</Nav.Link>
                        <Nav.Link href="#action2">Meus Chamados</Nav.Link>
                    
                    </Nav>

                </Offcanvas.Body>
            </Offcanvas>
        </Container>
    </Navbar>
    
  );
}

export default Sidebar;
