import React, {useState,useEffect} from 'react';
import { DataTable } from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';

import CustomButton from '../components/CustomButton';

import {useNavigation} from '@react-navigation/native';




const Cronograma = () => {
  const navigation=useNavigation();
  const handleButtonPress = () => {
    navigation.navigate("CadastrarCronograma");
  };

  const [items] = React.useState([
   {
     key: 1,     
     atividade: 'atividade1',
     responsavel: 'CPA Local',
     datainicio:'01/01/01',
     datatermino:'31/12/01',
     procedimento: 'Exemplo1',
   },
   {
     key: 2,     
     atividade: 'atividade2',
     responsavel: 'CPA Central',
     datainicio:'01/01/01',
     datatermino:'31/12/01',
     procedimento: 'Exemplo2',
   },
   
  ]);
  
  return(
   <Container>
      <Header title={'Cronograma'}></Header>
      <Body>
     <CustomButton text={'Novo'} color={'#2f9e41'} onPress={handleButtonPress}/>
    

      <DataTable>
        <DataTable.Header>
          <DataTable.Title>Descrição das Atividades</DataTable.Title>
          <DataTable.Title>Responsável</DataTable.Title>
          <DataTable.Title>Data Início</DataTable.Title>
          <DataTable.Title>Data Término</DataTable.Title>
          <DataTable.Title>Procedimentos</DataTable.Title>
               
        </DataTable.Header>
        {items.map((item) => (
        <DataTable.Row key={item.key}>
        
          <DataTable.Cell number>{item.atividade}</DataTable.Cell>
          <DataTable.Cell>{item.responsavel}</DataTable.Cell>
          <DataTable.Cell>{item.datainicio}</DataTable.Cell>
          <DataTable.Cell>{item.datatermino}</DataTable.Cell>
          <DataTable.Cell>{item.procedimento}</DataTable.Cell>
        </DataTable.Row>
      ))}
      </DataTable>
    
      <CustomButton text={'Próximo'} color={'#2f9e41'}/>
      <CustomButton text={'Voltar'} color={'#cd191e'}/>
      
      </Body>
    </Container>
  );
};


export default Cronograma;
