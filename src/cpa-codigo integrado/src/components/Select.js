import React,{useState} from 'react';
import {StyleSheet,Text} from 'react-native';

import { SelectList } from 'react-native-dropdown-select-list'

const Select = ({text,data}) => {
  const [selected, setSelected] = useState("");
  return(
    <>
    <Text style={styles.textselect}>{text}</Text>
    <SelectList style={styles.select}
        setSelected={(val) => setSelected(val)} 
        data={data} 
        save="value"
      /> 
    </>    
  )
};
const styles=StyleSheet.create({
  textselect:{
    marginTop:8,    
  },
  select:{
    marginBottom:8

  },
  
});

export default Select

        