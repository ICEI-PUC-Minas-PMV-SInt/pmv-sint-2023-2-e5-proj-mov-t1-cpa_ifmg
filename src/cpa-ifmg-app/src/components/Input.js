import React from 'react';
import { StyleSheet,Text } from 'react-native';
import { TextInput } from 'react-native-paper';

const Input = ({text,left,editable,props}) => {
  return (
    <>
    <Text style={styles.textselect}>{text}</Text>
    <TextInput  
    mode='outlined'
    style={styles.input}     
    left={left}
    editable={editable}
    keyboardType='default' {...props}
    
    />
    </>
  );
};
const styles = StyleSheet.create({
  textselect:{
    marginTop:8,    
  },
  input: {
    marginBottom: 8,
    backgroundColor: '#FFF',
  }
});

export default Input;
