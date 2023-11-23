import React,{useState} from 'react';
import {StyleSheet,TextInput,TouchableOpacity} from 'react-native';
import {Appbar} from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';
import Select from '../components/Select';
import CustomButton from '../components/CustomButton';
import Input from '../components/Input';
import {useNavigation} from '@react-navigation/native';
import DateTimePicker from '@react-native-community/datetimepicker';
import moment from 'moment';

const CadastrarCronograma = ()=> {
  
  const[procedimento,setProcedimento]=useState('');
  const[atividade,setAtividade]=useState('');
  const [date, setDate]=useState(new Date());
  const [show, setShow]=useState(false);
  const [data,setData]=useState('');
  const responsavel_data = [
      {key:'1', value:'CPA-Local'},
      {key:'2', value:'CPA-Central'},
           
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
      <Header title={'Cadastrar Cronograma'}
        goBack={()=>{navigation.goBack()} }>
        <Appbar.Action icon="check" onPress={handleSalvar} />
        <Appbar.Action icon="trash-can" onPress={handleExcluir} />
     </Header>
      <Body>
        <Input
          text={"Descrição das Atividades"}
          
          value={atividade}
          onChangeText={atividade=>setAtividade(atividade)}
        />
        <Select text={'Responsavel'} data={responsavel_data} setSelected={(data) => setSelected(data)}/>       
        
        <Input
          text={"Procedimentos"}
          
          value={procedimento}
          onChangeText={procedimento=>setProcedimento(procedimento)}
        />
        {show &&(
        <DateTimePicker
          testID="dateTimePicker"
          value={date}
          mode={'date'}
          is24Hour={true}
          display="default"
          onTouchCancel={()=>setShow(false)}
          onChange={(event,date)=>{
            setShow(false);
            setData(moment(date).format('DD/MM/YYYY'));
          }}
        
        />)}
        <TouchableOpacity onPress={()=> setShow(true)}>
        <Input
          text={"Data Início"}          
          value={data}                 
          editable={false}

        />
        </TouchableOpacity>
         <TouchableOpacity onPress={()=> setShow(true)}>
        <Input
          text={"Data Término"}          
          value={data}                 
          editable={false}

        />
        </TouchableOpacity>
        <CustomButton text={'Cadastrar'} color={'#2f9e41'} onPress={handleSalvar}/>
        <CustomButton text={'Excluir'} color={'#cd191e'} onPress={handleExcluir} />
      
      </Body>
    </Container>
  )
};


export default CadastrarCronograma;