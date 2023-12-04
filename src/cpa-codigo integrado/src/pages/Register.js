import React, { useState } from 'react';
import { StyleSheet, View, Alert } from 'react-native';
import { TextInput, Button, Headline } from 'react-native-paper';
import Container from '../components/Container';
import Body from '../components/Body';
import Input from '../components/Input';
import Logo from '../components/Logo';
import Select from '../components/Select';

import { useNavigation } from '@react-navigation/native';

import {register} from '../services/auth.services';

const Register = () => {

  const navigation = useNavigation();
  
  const [name, setName] = useState('Nome Usuário');
  const [email, setEmail] = useState('usuario@exemplo.com');
  const [password, setPassword] = useState('123456');
  const [cpf, setCpf] = useState('000.000.000-00');

              const perfil_data = [
      {key:'1', value:'Discente'},
      {key:'2', value:'Docente'},
      {key:'3', value:'Técnico Administrativo'},
      {key:'4', value:'Comunidade Externa'},
  ]

        const campus_data = [
      {key:'1', value:'Arcos'},
      {key:'2', value:'Bambuí'},
      {key:'3', value:'Betim'},
      {key:'4', value:'Congonhas'},
      {key:'5', value:'Conselheiro Lafaiete'},
      {key:'6', value:'Itabirito'},
      {key:'7', value:'Ibirite'},
  ]

  const handleRegister = () => {

    register({
      name: name,
      email: email,
      password: password,
      cpf: cpf, 
      perfil: perfil_data,
      campus: campus_data
    }).then( res => {
      console.log(res);

      if(res){

        Alert.alert('Atenção', 'Usuário Cadastrado com sucesso!',[
          { text: "OK", onPress: () => navigation.goBack() }
        ]);

      }else{

         Alert.alert('Atenção', 'Usuário não cadastrado! Tente novamente mais tarde =D');
      }

    });
    
  }

  return (
    <Container>
      <View style={styles.header}>
        <Logo />
      </View>

      <Headline style={styles.textHeader}>Cadastro de Usuário</Headline>

      <Body>
      <Input
          text={'Nome Completo'}
          value={name}
          onChangeText={(text) => setName(text)}
          left={<TextInput.Icon name="account" />}
        />
      <Select text={'Perfil'}  value={perfil_data} data={perfil_data} setSelected={(data) => setSelected(data)}/>
      <Select text={'Campus'}  value={campus_data} data={campus_data} setSelected={(data) => setSelected(data)}/>

        <Input
          text={'Email'}
          value={email}
          onChangeText={(text) => setEmail(text)}
          left={<TextInput.Icon name="email" />}
        />

        <Input
          text={'CPF'}
          value={cpf}
          onChangeText={(text) => setCpf(text)}
          left={<TextInput.Icon name="badge-account-horizontal-outline" />}
        />

        <Input
          text={'Senha'}
          value={password}
          secureTextEntry
          onChangeText={(text) => setPassword(text)}
          left={<TextInput.Icon name="key" />}

        />

        
        <Button
             color={'#2f9e41'}
          style={styles.button}
          mode="contained"
          onPress={handleRegister}>
          CADASTRAR
        </Button>
        <Button
             color={'#2f9e41'}
          style={styles.button}
          mode="outlined"
          onPress={() => navigation.goBack()}>
          VOLTAR
        </Button>
      </Body>
    </Container>
  );
};

const styles = StyleSheet.create({
  button: {
    marginBottom: 8,
    marginTop:8,
    borderRadius:10,
  },
  textHeader: {
    textAlign: 'center',
    fontWeight: 'bold',
  },
  header: {
    alignItems: 'center',
    marginTop: 30,
    marginBottom: 12
  },
});

export default Register;
