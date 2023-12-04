import React,{useState} from 'react';
import {StyleSheet,TextInput,TouchableOpacity} from 'react-native';
import {Appbar} from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';
import Select from '../components/Select';
import CustomButton from '../components/CustomButton';
import {useNavigation} from '@react-navigation/native';


const CadastrarCursos = ()=> {
  
  const[procedimento,setProcedimento]=useState('');
  const[atividade,setAtividade]=useState('');
  const [date, setDate]=useState(new Date());
  const [show, setShow]=useState(false);
  const [data,setData]=useState('');
  const atuacao_data = [
      {key:'1', value:'Engenharias'},
      {key:'2', value:'Ciências Biológicas'},
           
  ]
  const eixo_data = [
      {key:'1', value:'Ambiente e Saúde'},
      {key:'2', value:'Gestão e Negócios'},
           
  ]
  const nome_data = [
      {key:'1', value:'Engenharia Elétrica'},
      {key:'2', value:'Ciências Biológicas'},
           
  ]
  const nivel_data = [
      {key:'1', value:'Bacharelado'},
      {key:'2', value:'Licenciatura'},
           
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
      <Header title={'Cadastrar Cursos'}
        goBack={()=>{navigation.goBack()} }>
        <Appbar.Action icon="check" onPress={handleSalvar} />
        <Appbar.Action icon="trash-can" onPress={handleExcluir} />
     </Header>
      <Body>
      <Select text={'Grande Área de Atuação'} data={atuacao_data} setSelected={(data) => setSelected(data)}/>       
      <Select text={'Eixo Tecnológico'} data={eixo_data} setSelected={(data) => setSelected(data)}/>  
      <Select text={'Nome'} data={nome_data} setSelected={(data) => setSelected(data)}/>
      <Select text={'Nível'} data={nivel_data} setSelected={(data) => setSelected(data)}/>      
        
        
        <CustomButton text={'Cadastrar'} color={'#2f9e41'} onPress={handleSalvar}/>
        <CustomButton text={'Excluir'} color={'#cd191e'} onPress={handleExcluir} />
      
      </Body>
    </Container>
  )
};


export default CadastrarCursos;