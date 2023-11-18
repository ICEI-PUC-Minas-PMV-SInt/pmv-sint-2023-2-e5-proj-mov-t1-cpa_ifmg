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

const CadastrarMelhoria = ()=> {
  
  const[melhoria,setMelhoria]=useState('');
  const eixo_data = [
      {key:'1', value:'1-Planejamento e Avaliação Institucional'},
      {key:'2', value:'2-Desenvolvimento Institucional'},
      {key:'3', value:'3-Políticas Acadêmicas'},
      {key:'4', value:'4-Políticas de Gestão'},
      {key:'5', value:'5-Infraestrutura'},      
  ]
  const dimensao_data = [
      {key:'1', value:'1-Missão e Plano de Desenvolvimento Institucional'},
      {key:'2', value:'2-Políticas para o Ensino, a Pesquisa e a Extensão'},
      {key:'3', value:'3-Responsabilidade Social da Instituição'},
      {key:'4', value:'4-Comunicação com a Sociedade'},
      {key:'5', value:'5-Políticas de Pessoal'},
      {key:'6', value:'6-Organização e Gestão da Instituição'},
      {key:'7', value:'7-Infraestrutura Física'},
      {key:'8', value:'8-Planejamento e Avaliação'},
      {key:'9', value:'9-Política de Atendimento aos Discentes'},
      {key:'10', value:'10-Sustentabilidade Financeira'},

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
      <Header title={'Cadastrar Melhoria'}
        goBack={()=>{navigation.goBack()} }>
        <Appbar.Action icon="check" onPress={handleSalvar} />
        <Appbar.Action icon="trash-can" onPress={handleExcluir} />
     </Header>
      <Body>
        <Select text={'Eixo'} data={eixo_data} setSelected={(data) => setSelected(data)}/>
        <Select text={'Dimensão'} data={dimensao_data} setSelected={(data) => setSelected(data)}/>
        
        <Input
          text={"Proposta de Melhoria"}
          
          value={melhoria}
          onChangeText={melhoria=>setMelhoria(melhoria)}
        />
        <CustomButton text={'Cadastrar'} color={'#2f9e41'} onPress={handleSalvar}/>
        <CustomButton text={'Excluir'} color={'#cd191e'} onPress={handleExcluir} />
      
      </Body>
    </Container>
  )
};


export default CadastrarMelhoria;