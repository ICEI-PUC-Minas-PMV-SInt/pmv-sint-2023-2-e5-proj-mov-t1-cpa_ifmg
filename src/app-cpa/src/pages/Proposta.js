import React,{useEffect,useState} from 'react';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';
import Input from '../components/Input';
import Select from '../components/Select';
import CustomButton from '../components/CustomButton';
import {useNavigation} from '@react-navigation/native';

import {getCampus} from '../services/campus.services';



const Proposta = () => {
  const navigation=useNavigation();
  
 const[campus,setCampus]=useState([]);
  
  // useEffect(()=>{
  //  getCampus().then(dados=>
  //  {console.log(dados);
  //  setCampus(dados);   
  //  });
  // },[]);

  const campus_data = [
      {key:'1', value:'Arcos'},
      {key:'2', value:'Bambuí'},
      {key:'3', value:'Betim'},
      {key:'4', value:'Congonhas'},
      {key:'5', value:'Conselheiro Lafaiete'},
      {key:'6', value:'Itabirito'},
      {key:'7', value:'Ibirite'},
  ]
  const tipo_data = [
      {key:'1', value:'Cadastro Membros'},
      {key:'2', value:'Relatorio'},
      
  ]
  const handleSalvar=()=>{
    proposta({
      campi:campus_data,
      tipo:tipo_data


    }).then(res => {
      console.log(res)
    })
  }
 

   return(
   <Container>
      <Header title={'Nova Proposta'}></Header>
      <Body>
      <Select text={'Campus'} data={campus_data} setSelected={(data) => setSelected(data)}/>
      <Select text={'Tipo'} data={tipo_data} setSelected={(data) => setSelected(data)}/>
      <CustomButton text={'Próximo'} color={'#2f9e41'} onPress={()=> navigation.navigate('Inicio')}/>
      <CustomButton text={'Voltar'} color={'#cd191e'}/>
      
      </Body>
    </Container>
  );
};


export default Proposta;
