import React,{useState} from 'react';
import { StyleSheet } from 'react-native';

import {Button} from 'react-native-paper';

const CustomButton = ({ text, onPress,color, mode }) => {
  return (
    <Button style={styles.button} mode={mode} onPress={onPress} color={color}>          
      {text}
    </Button>
  );
};


const styles=StyleSheet.create({
  
  button:{
   
    marginTop:8,
    marginBottom:8,
    borderRadius:10                                        //MODIFIQUEI                                                   
  }
});

export default CustomButton;