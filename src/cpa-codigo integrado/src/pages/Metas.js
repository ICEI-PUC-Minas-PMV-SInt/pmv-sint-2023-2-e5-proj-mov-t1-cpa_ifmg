import React, {useState,useEffect} from 'react';
import { DataTable } from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';

import CustomButton from '../components/CustomButton';

import {useNavigation} from '@react-navigation/native';




const Metas = () => {
  const navigation=useNavigation();
  const handleButtonPress = () => {
    navigation.navigate("CadastrarMetas");
  };

  const [items] = React.useState([
   {
     key: 1,     
     meta: 'teste',
     atividade:'teste',
     prazo: 'teste',
     responsavel: 'teste',
     
   },
   {
     key: 2,     
     meta: 'teste',
     atividade:'teste',
     prazo: 'teste',
     responsavel: 'teste',
     
   },
   
  ]);
  
  return(
   <Container>
      <Header title={'Metas'}></Header>
      <Body>
     <CustomButton text={'Novo'} color={'#2f9e41'} onPress={handleButtonPress}/>
    

      <DataTable>
        <DataTable.Header>
          <DataTable.Title>Meta</DataTable.Title>
          <DataTable.Title>Atividade</DataTable.Title>
          <DataTable.Title>Prazo</DataTable.Title>
          <DataTable.Title>Responsável</DataTable.Title>
          
               
        </DataTable.Header>
        {items.map((item) => (
        <DataTable.Row key={item.key}>
        
          <DataTable.Cell number>{item.meta}</DataTable.Cell>
          <DataTable.Cell>{item.atividade}</DataTable.Cell>
          <DataTable.Cell>{item.prazo}</DataTable.Cell>
          <DataTable.Cell>{item.responsavel}</DataTable.Cell>
          
        </DataTable.Row>
      ))}
      </DataTable>
    
      <CustomButton text={'Próximo'} color={'#2f9e41'}/>
      <CustomButton text={'Voltar'} color={'#cd191e'} onPress={()=> navigation.navigate('Inicio')}/>
      
      </Body>
    </Container>
  );
};


export default Metas;
