import React, { useState } from 'react';
import { NavigationContainer } from '@react-navigation/native';
import Route from './src/navigations/Route';
import UserProvider from './src/contexts/UserContext';
import Register from './src/pages/Register';
import Main from './src/navigations/Main';

const App = () => {
  return (
        <UserProvider>
    <NavigationContainer>
      <Route />
    </NavigationContainer>
        </UserProvider>
  );
};
export default App;
