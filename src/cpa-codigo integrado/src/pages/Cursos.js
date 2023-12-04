import React, {useState,useEffect} from 'react';
import { DataTable } from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';

import CustomButton from '../components/CustomButton';

import {useNavigation} from '@react-navigation/native';




const Cursos = () => {
  const navigation=useNavigation();
  const handleButtonPress = () => {
    navigation.navigate("CadastrarCursos");
  };

  const [items] = React.useState([
   {
     key: 1,     
     atuacao: 'Engenharias',
     eixo: ' ',
     nome:'Engenharia Elétrica',
     nivel: 'Bacharelado',
   },
   {
     key: 2,     
     atuacao: 'Ciências Biológicas',
     eixo: 'Ambiente e Saúde',
     nome:'Ciências Biológicas',
     nivel: 'Licenciatura',
   },
   
  ]);
  
  return(
   <Container>
      <Header title={'Cursos'}></Header>
      <Body>
     <CustomButton text={'Novo'} color={'#2f9e41'} onPress={handleButtonPress}/>
    

      <DataTable>
        <DataTable.Header>
          <DataTable.Title>Grande Área de Atuação</DataTable.Title>
          <DataTable.Title>Eixo Tecnológico</DataTable.Title>
          <DataTable.Title>Nome</DataTable.Title>
          <DataTable.Title>Nível</DataTable.Title>
               
        </DataTable.Header>
        {items.map((item) => (
        <DataTable.Row key={item.key}>
        
          <DataTable.Cell number>{item.atuacao}</DataTable.Cell>
          <DataTable.Cell>{item.eixo}</DataTable.Cell>
          <DataTable.Cell>{item.nome}</DataTable.Cell>
          <DataTable.Cell>{item.nivel}</DataTable.Cell>
        </DataTable.Row>
      ))}
      </DataTable>
    
      <CustomButton text={'Próximo'} color={'#2f9e41'}/>
      <CustomButton text={'Voltar'} color={'#cd191e'} onPress={()=> navigation.navigate('Inicio')}/>
      
      </Body>
    </Container>
  );
};


export default Cursos;
