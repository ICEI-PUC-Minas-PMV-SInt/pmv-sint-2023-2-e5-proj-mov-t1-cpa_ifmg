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
  
  const[meta,setMeta]=useState('');
  const[atividade,setAtividade]=useState('');
  const[prazo,setPrazo]=useState('');
  const responsavel_data = [
      {key:'1', value:'CPA Central'},
      {key:'2', value:'CPA Local'},
      {key:'3', value:'CPA Central e CPA Local'},     
           
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
      <Header title={'Cadastrar Metas'}
        goBack={()=>{navigation.goBack()} }>
        <Appbar.Action icon="check" onPress={handleSalvar} />
        <Appbar.Action icon="trash-can" onPress={handleExcluir} />
     </Header>
      <Body>
        <Input
          text={"Meta"}
          
          value={meta}
          onChangeText={meta=>setMeta(meta)}
        />
        <Input
          text={"Atividade"}
          
          value={atividade}
          onChangeText={atividade=>setAtividade(atividade)}
        />
        <Input
          text={"Prazo"}
          
          value={prazo}
          onChangeText={prazo=>setPrazo(prazo)}
        />
        <Select text={'Responsavel'} data={responsavel_data} setSelected={(data) => setSelected(data)}/>       
        
        
        <CustomButton text={'Cadastrar'} color={'#2f9e41'} onPress={handleSalvar}/>
        <CustomButton text={'Excluir'} color={'#cd191e'} onPress={handleExcluir} />
      
      </Body>
    </Container>
  )
};


export default CadastrarMembros;