import React from 'react';
import {StyleSheet} from 'react-native';
import {Appbar} from 'react-native-paper';


const Header = ({title, goBack, children}) => {
  

  return (
    <Appbar.Header style={styles.header}>
      {
        goBack &&
        <Appbar.BackAction onPress={goBack}/>
      }
      
      <Appbar.Content style={styles.title} title={title} />
      {children}
      
    </Appbar.Header>
  );
};
const styles=StyleSheet.create({
 title:{
   alignItems:'center'
 }, 
  header:{
    backgroundColor:'#2f9e41'
  
  }
});

export default Header;