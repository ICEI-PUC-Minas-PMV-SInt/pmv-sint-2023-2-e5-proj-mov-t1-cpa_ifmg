import React, { useState } from 'react';
import { StyleSheet, View, Alert } from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { TextInput, Button, Headline } from 'react-native-paper';
import Container from '../components/Container';
import Body from '../components/Body';
import Input from '../components/Input';
import Logo from '../components/Logo';

import { useNavigation } from '@react-navigation/native';
import { useUser } from '../contexts/UserContext';
import CustomButton from '../components/CustomButton';

import { login } from '../services/auth.services';

const Login = () => {
  const navigation = useNavigation();
  const { setSigned, setName } = useUser();

  const [email, setEmail] = useState('usuario@exemplo.com');
  const [password, setPassword] = useState('123456');

  const handleExcluir = () => {
    console.log('Excluir');
  };

  const handleLogin = () => {
    login({
      email: email,
      password: password,
    }).then((res) => {
      console.log(res);

      if (res && res.user) {
        setSigned(true);
        setName(res.user.name);
        AsyncStorage.setItem('@TOKEN_KEY', res.accessToken).then();
      } else {
        Alert.alert('Atenção', 'Usuário ou senha inválidos!');
      }
    });
  };

  return (
    <Container>
      <View style={styles.header}>
        <Logo />
      </View>

      <Headline style={styles.textHeader}>AVALIAÇÃO INTITUCIONAL</Headline>

      <Body>
        <Input
          text={'Email'}
          value={email}
          onChangeText={(text) => setEmail(text)}
          left={<TextInput.Icon name="account" />}
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
          onPress={handleLogin}>
          Entrar
        </Button>

        <Button
          color={'#000000'}
          style={styles.button}
          mode="text"
          onPress={() => navigation.navigate('RecuperarSenha')}>
          Esqueci minha senha
        </Button>

        <Button
          color={'#2f9e41'}
          style={styles.button}
          mode="text"
          onPress={() => navigation.navigate('LoginMembro')}>
          Membros CPA
        </Button>

        <Button
          color={'#2f9e41'}
          style={styles.button}
          mode="text"
          onPress={() => navigation.navigate('Register')}>
          Novo Usuário
        </Button>
      </Body>
    </Container>
  );
};

const styles = StyleSheet.create({
  button: {
    marginBottom: 8,
    marginTop: 8,
    borderRadius: 10,
  },
  textHeader: {
    textAlign: 'center',
    fontWeight: 'bold',
  },
  header: {
    alignItems: 'center',
    marginTop: 60,
    marginBottom: 20,
  },
});

export default Login;
