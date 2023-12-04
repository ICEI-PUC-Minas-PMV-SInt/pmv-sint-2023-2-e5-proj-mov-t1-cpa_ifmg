import React, { useState } from 'react';
import { StyleSheet, View, Alert } from 'react-native';
import { TextInput, Button, Headline } from 'react-native-paper';
import Container from '../components/Container';
import Body from '../components/Body';
import Input from '../components/Input';
import Logo from '../components/Logo';


import { useNavigation } from '@react-navigation/native';

import {recuperarsenha} from '../services/auth.services';

const RecuperarSenha = () => {

  const navigation = useNavigation();
  

  const [cpf, setCpf] = useState('000.000.000-00');



  const handleRegister = () => {

    recuperarsenha({
      cpf: cpf,
    }).then( res => {
      console.log(res);

      if(res){

        Alert.alert('Atenção', 'Nova senha enviada com sucesso!',[
          { text: "OK", onPress: () => navigation.goBack() }
        ]);

      }else{

         Alert.alert('Atenção', 'Usuário não cadastrado! Faça seu cadastro!');
      }

    });
    
  }

  return (
    <Container>
      <View style={styles.header}>
        <Logo />
      </View>

      <Headline style={styles.textHeader}>Recuperar Senha</Headline>

      <Body>

        <Input
          text={'CPF'}
          value={cpf}
          onChangeText={(text) => setCpf(text)}
          left={<TextInput.Icon name="badge-account-horizontal-outline" />}
        />

        
        <Button
             color={'#2f9e41'}
          style={styles.button}
          mode="contained"
          onPress={handleRegister}>
          ENVIAR PARA EMAIL
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

export default RecuperarSenha;