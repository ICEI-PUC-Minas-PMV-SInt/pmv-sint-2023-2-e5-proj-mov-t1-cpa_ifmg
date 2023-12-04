import React, {useState,useEffect} from 'react';
import { DataTable,Appbar } from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';
import CustomButton from '../components/CustomButton';
import {useNavigation} from '@react-navigation/native';




const Melhoria = () => {
  const navigation=useNavigation();
  const handleButtonPress = () => {
    navigation.navigate("CadastrarMelhoria");
  };

  const [items] = React.useState([
   {
     key: 1,
     
     eixo: 3,
     nome: 'Intensificar, na comunidade acadêmica, a imporância de acesso às redes sociais e site do campus, para estar por dentro das notícias. Atualização constante das TVs de comunicação do campus, com notícias recentes.',
     dimensao: 'Comunicação com a sociedade',
   },
   {   
     key: 2,
     
     eixo: 3,
     nome: 'Intensificar, na comunidade acadêmica, a imporância de acesso às redes sociais e site do campus, para estar por dentro das notícias. Atualização constante das TVs de comunicação do campus, com notícias recentes.',
     dimensao: 'Comunicação com a sociedade',
   },
   {   
     key: 3,
     
     eixo: 3,
     nome: 'Intensificar, na comunidade acadêmica, a imporância de acesso às redes sociais e site do campus, para estar por dentro das notícias. Atualização constante das TVs de comunicação do campus, com notícias recentes.',
     dimensao: 'Comunicação com a sociedade',
   }
   
  ]);
  
  return(
   <Container>
      <Header title={'Propostas de Melhoria'}>    
      </Header>
      <Body>
     <CustomButton text={'Novo'} color={'#2f9e41'} onPress={handleButtonPress}/>
    

      <DataTable>
        <DataTable.Header>
          <DataTable.Title>Eixo</DataTable.Title>
          <DataTable.Title>Dimensão</DataTable.Title>
          <DataTable.Title>Proposta de Melhoria</DataTable.Title>
               
        </DataTable.Header>
        {items.map((item) => (
        <DataTable.Row key={item.key}>
        
          <DataTable.Cell number>{item.eixo}</DataTable.Cell>
          <DataTable.Cell>{item.nome}</DataTable.Cell>
          <DataTable.Cell>{item.dimensao}</DataTable.Cell>
        </DataTable.Row>
      ))}
      </DataTable>
    
      <CustomButton text={'Próximo'} color={'#2f9e41'}/>
      <CustomButton text={'Voltar'} color={'#cd191e'} onPress={()=> navigation.navigate('Inicio')}/>
      
      </Body>
    </Container>
  );
};


export default Melhoria;
