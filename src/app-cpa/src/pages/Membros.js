import React, {useState,useEffect} from 'react';
import { DataTable } from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';

import CustomButton from '../components/CustomButton';

import {useNavigation} from '@react-navigation/native';




const Membros = () => {
  const navigation=useNavigation();
  const handleButtonPress = () => {
    navigation.navigate("CadastrarMembros");
  };

  const [items] = React.useState([
   {
     key: 1,     
     portaria: 'teste',
     nome:'teste',
     representacao: 'teste',
     funcao: 'teste',
     acao:'teste'
   },
   {
     key: 2,     
     portaria: 'teste',
     nome:'teste',
     representacao: 'teste',
     funcao: 'teste',
     acao:'teste'
   },
   
  ]);
  
  return(
   <Container>
      <Header title={'Membros'}></Header>
      <Body>
     <CustomButton text={'Novo'} color={'#2f9e41'} onPress={handleButtonPress}/>
    

      <DataTable>
        <DataTable.Header>
          <DataTable.Title>Portaria</DataTable.Title>
          <DataTable.Title>Nome</DataTable.Title>
          <DataTable.Title>Representação</DataTable.Title>
          <DataTable.Title>Função</DataTable.Title>
          <DataTable.Title>Ação</DataTable.Title>
               
        </DataTable.Header>
        {items.map((item) => (
        <DataTable.Row key={item.key}>
        
          <DataTable.Cell number>{item.portaria}</DataTable.Cell>
          <DataTable.Cell>{item.nome}</DataTable.Cell>
          <DataTable.Cell>{item.representacao}</DataTable.Cell>
          <DataTable.Cell>{item.funcao}</DataTable.Cell>
          <DataTable.Cell>{item.acao}</DataTable.Cell>
        </DataTable.Row>
      ))}
      </DataTable>
    
      <CustomButton text={'Próximo'} color={'#2f9e41'}/>
      <CustomButton text={'Voltar'} color={'#cd191e'} onPress={()=> navigation.navigate('Inicio')}/>
      
      </Body>
    </Container>
  );
};


export default Membros;
