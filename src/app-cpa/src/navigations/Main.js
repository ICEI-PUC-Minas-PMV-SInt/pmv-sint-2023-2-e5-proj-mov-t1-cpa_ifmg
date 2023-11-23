import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import Home from '../pages/Home';
import Inicio from '../pages/Inicio';
import CadastrarMelhoria from '../pages/CadastrarMelhoria';
import CadastrarCronograma from '../pages/CadastrarCronograma';
import CadastrarCursos from '../pages/CadastrarCursos';
import CadastrarMembros from '../pages/CadastrarMembros';
import CadastrarMetas from '../pages/CadastrarMetas';
import Proposta from '../pages/Proposta';
import Melhoria from '../pages/Melhoria';
import Cronograma from '../pages/Cronograma';
import Cursos from '../pages/Cursos';
import Membros from '../pages/Membros';
import Metas from '../pages/Metas';

const Stack = createNativeStackNavigator();

const Main=()=>{
  return(
    
    <Stack.Navigator initialRouteName="Home">
        <Stack.Screen name="Home" 
        component={Home}
        options={{
          header:()=>null
        }} 
        />
        <Stack.Screen name="Inicio" 
        component={Inicio}
        options={{
          header:()=>null
        }} 
        />
        <Stack.Screen name="Proposta" 
        component={Proposta}
        options={{
          header:()=>null
        }} 
        />
        <Stack.Screen name="Cronograma" 
        component={Cronograma}
        options={{
          header:()=>null
        }} 
        />
        <Stack.Screen name="Melhoria" 
        component={Melhoria}
        options={{
          header:()=>null
        }} 
        />
        <Stack.Screen name="Cursos" 
        component={Cursos}
        options={{
          header:()=>null
        }} 
        /> 
        <Stack.Screen name="Membros" 
        component={Membros}
        options={{
          header:()=>null
        }} 
        /> 
        <Stack.Screen name="Metas" 
        component={Metas}
        options={{
          header:()=>null
        }} 
        />                      
        <Stack.Screen name="CadastrarMelhoria" 
        component={CadastrarMelhoria}
        options={{
         header:()=>null
        }}
         />
         <Stack.Screen name="CadastrarCronograma" 
        component={CadastrarCronograma}
        options={{
          header:()=>null
        }}
         />
        <Stack.Screen name="CadastrarCursos" 
        component={CadastrarCursos}
        options={{
          header:()=>null
        }}
         />
         <Stack.Screen name="CadastrarMembros" 
        component={CadastrarMembros}
        options={{
          header:()=>null
        }}
         />  
         <Stack.Screen name="CadastrarMetas" 
        component={CadastrarMetas}
        options={{
          header:()=>null
        }}
         />  
    </Stack.Navigator>
    

  );
}

export default Main;