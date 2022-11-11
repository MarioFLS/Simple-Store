import { Box, Container, Paper, styled, TableBody, TableCell, tableCellClasses, TableContainer, TableHead, TableRow } from '@mui/material';
import React, { useEffect, useState } from 'react';
import { Table } from 'reactstrap';
import formatDate from '../helpers/formatDate';

export const Home = () => {

  const [departaments, setDepartaments] = useState([])
  const [sellers, setSellers] = useState([])

  const StyledTableCell = styled(TableCell)(({ theme }) => ({
    [`&.${tableCellClasses.head}`]: {
      backgroundColor: theme.palette.common.black,
      color: theme.palette.common.white,
    },
    [`&.${tableCellClasses.body}`]: {
      fontSize: 14,
    },
  }));

  const StyledTableRow = styled(TableRow)(({ theme }) => ({
    '&:nth-of-type(odd)': {
      backgroundColor: theme.palette.action.hover,
    },
    // hide last border
    '&:last-child td, &:last-child th': {
      border: 0,
    },
  }));




  const getDepartaments = async () => {
    const response = await fetch('department');
    const data = await response.json();
    setDepartaments(data);
  }

  const getSellers = async () => {
    const response = await fetch('seller');
    const data = await response.json();
    setSellers(data);
  }

  useEffect(() => {
    (async () => { await getDepartaments(); await getSellers() })();
  }, [])

  //console.log(sellers)
  return (
    <Container component="main">
      <h1>Lista de Vendedores</h1>

      <Box>
        <TableContainer component={Paper}>
          <Table sx={{ minWidth: 700 }} aria-label="customized table">
            <TableHead>
              <TableRow>
                <StyledTableCell>Nome</StyledTableCell>
                <StyledTableCell align="center">email</StyledTableCell>
                <StyledTableCell align="center">Salário</StyledTableCell>
                <StyledTableCell align="center">Aniversário</StyledTableCell>
                <StyledTableCell align="center">Departamento</StyledTableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {sellers.map((row) => (
                <StyledTableRow key={row.id}>
                  <StyledTableCell component="th" scope="row">
                    {row.name}
                  </StyledTableCell>
                  {console.log()}
                  <StyledTableCell align="center">{row.email}</StyledTableCell>
                  <StyledTableCell align="center">R$ {row.baseSalary.toFixed(2)}</StyledTableCell>
                  <StyledTableCell align="center">{formatDate(row.birthDate)}</StyledTableCell>
                  <StyledTableCell align="center">{departaments.find(d => d.id === row.departmentId)?.name}</StyledTableCell>
                </StyledTableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </Box>
    </Container>
  );
};
