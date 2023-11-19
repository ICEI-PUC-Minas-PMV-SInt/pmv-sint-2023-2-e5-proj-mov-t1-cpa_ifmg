import React, { useState } from 'react';
import { StyleSheet, View, Alert } from 'react-native';
import { TextInput, Button, Headline } from 'react-native-paper';
import Container from '../components/Container';
import Body from '../components/Body';
import Input from '../components/Input';
import Logo from '../components/Logo';

import { useNavigation } from '@react-navigation/native';

import {register} from '../services/auth.services';

const Register = () => {

  const navigation = useNavigation();
  
  const [name, setName] = useState('Nome Usuário');
  const [email, setEmail] = useState('usuario@exemplo.com');
  const [password, setPassword] = useState('123456');

  const handleRegister = () => {

    register({
      name: name,
      email: email,
      password: password
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
          label="Nome Completo"
          value={name}
          onChangeText={(text) => setName(text)}
          left={<TextInput.Icon name="account" />}
        />
        <Input
          label="E-mail"
          value={email}
          onChangeText={(text) => setEmail(text)}
          left={<TextInput.Icon name="email" />}
        />
                <Input
          label="Confirme o e-mail"
          value={email}
          onChangeText={(text) => setEmail(text)}
          left={<TextInput.Icon name="email" />}
        />
        <Input
          label="Senha"
          value={password}
          secureTextEntry
          onChangeText={(text) => setPassword(text)}
          left={<TextInput.Icon name="key" />}
        />
               <Input
          label="Confirme sua senha"
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
