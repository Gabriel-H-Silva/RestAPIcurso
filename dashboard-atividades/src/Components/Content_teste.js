import { Container, Row, Col, Button} from "react-bootstrap";
import Table from 'react-bootstrap/Table';
import { FaPencil,FaTrash  } from "react-icons/fa6";
import ContentModal from "./ContentModal";
import React, { useState } from 'react';

function Content_teste() {

  const [modalShow, setModalShow] = useState(false);

  return (

    <>
    <Container className='Custom_Container'>
      <Row>
        <Col>
          <h1 className="Title_custom">Chamados - Suporte</h1>
          <Table striped bordered hover>
            <thead>
              <tr>
                <th>Cliente</th>
                <th>Atividade</th>
                <th>Profissional</th>
                <th>Status</th>
                <th>Ações</th>
              </tr>
            </thead>
            <tbody>

              <tr>
                <td>World Games</td>
                <td>Erro no sla oq</td>
                <td></td>
                <td>Aberto</td>
                <td className='text-center'>
                  <Button variant="dark" className="btn_custom" onClick={() => setModalShow(true)}><FaPencil /></Button>
                  <Button variant="dark"><FaTrash /></Button>
                </td>

              </tr>

              <tr>
                <td>Fair Play</td>
                <td>Erro na leitora</td>
                <td>Hitalu</td>
                <td>Em Andamento</td>
                <td className='text-center'>
                  <Button variant="dark" className="btn_custom" onClick={() => setModalShow(true)}><FaPencil /></Button>
                  <Button variant="dark"><FaTrash /></Button>
                </td>
              </tr>

              <tr>
                <td>Gorilão</td>
                <td>Erro no fliper</td>
                <td>Luiz</td>
                <td>Aguardando - Desenvolvimento</td>
                <td className='text-center'>
                  <Button variant="dark" className="btn_custom" onClick={() => setModalShow(true)}><FaPencil /></Button>
                  <Button variant="dark"><FaTrash /></Button>
                </td>
              </tr>



            </tbody>
          </Table>
          <Button variant="dark" className="btn_custom" onClick={() => setModalShow(true)}>Novo Chamado</Button>
        </Col>
      </Row>
    </Container>
    <ContentModal show={modalShow} onHide={() => setModalShow(false)} />
    </>
  );
}

export default Content_teste;
