import React from 'react';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import Login from '../pages/Login';
import Register from '../pages/Register';
import LoginMembro from '../pages/LoginMembro';
import RecuperarSenha from '../pages/RecuperarSenha';

const Stack = createNativeStackNavigator();

const Main = () => {
  return (
    <Stack.Navigator initialRouteName="Login">
      <Stack.Screen
        name="Login"
        component={Login}
        options={{
          header: () => null,
        }}
      />
      <Stack.Screen
        name="Register"
        component={Register}
        options={{
          header: () => null,
        }}
      />
            <Stack.Screen
        name="LoginMembro"
        component={LoginMembro}
        options={{
          header: () => null,
        }}
      />

                  <Stack.Screen
        name="RecuperarSenha"
        component={RecuperarSenha}
        options={{
          header: () => null,
        }}
      />
    </Stack.Navigator>
  );
};

export default Main;
