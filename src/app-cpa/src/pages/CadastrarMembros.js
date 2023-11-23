import React,{useState} from 'react';
import {StyleSheet} from 'react-native';
import {Appbar} from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';
import Select from '../components/Select';
import CustomButton from '../components/CustomButton';
import Input from '../components/Input';
import {useNavigation} from '@react-navigation/native';

const CadastrarMembros = ()=> {
  
  const[portaria,setPortaria]=useState('');
  const[nome,setNome]=useState('');
  const representacao_data = [
      {key:'1', value:'Docente(Titular)'},
      {key:'2', value:'Docente(Suplente)'},
      {key:'3', value:'Discente(Titular)'},
      {key:'4', value:'Discente(Suplente)'},
      {key:'5', value:'Técnico-administrativo(Titular)'},
      {key:'6', value:'Técnico-administrativo(Suplente)'},
      {key:'7', value:'Sociedade Civil Organizada(Titular)'},
      {key:'8', value:'Sociedade Civil Organizada(Suplente)'},
           
  ]
  const funcao_data = [
      {key:'1', value:'Presidente'},
      {key:'2', value:'Vice-Presidente'},
      {key:'3', value:'Membro'},
     
  ]
  const handleSalvar=()=>{
    console.log('Salvar');
  }
  const handleExcluir=()=>{
    console.log('Excluir');
  }
  
  const navigation=useNavigation();  
  return(
    <Container>
      <Header title={'Cadastrar Membros'}
        goBack={()=>{navigation.goBack()} }>
        <Appbar.Action icon="check" onPress={handleSalvar} />
        <Appbar.Action icon="trash-can" onPress={handleExcluir} />
     </Header>
      <Body>
        <Input
          text={"Portaria"}
          
          value={portaria}
          onChangeText={portaria=>setPortaria(portaria)}
        />
        <Input
          text={"Nome"}
          
          value={nome}
          onChangeText={nome=>setNome(nome)}
        />
        <Select text={'Eixo'} data={representacao_data} setSelected={(data) => setSelected(data)}/>
        <Select text={'Dimensão'} data={funcao_data} setSelected={(data) => setSelected(data)}/>
        
        
        <CustomButton text={'Cadastrar'} color={'#2f9e41'} onPress={handleSalvar}/>
        <CustomButton text={'Excluir'} color={'#cd191e'} onPress={handleExcluir} />
      
      </Body>
    </Container>
  )
};


export default CadastrarMembros;