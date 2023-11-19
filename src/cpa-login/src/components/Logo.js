import React from 'react';
import {StyleSheet, Image} from 'react-native';

const Logo = () =>{
  return <Image style={styles.image} source={require('../assets/ifmg.png')} />
};

const styles = StyleSheet.create({
 image:{
    width: 150,
    height: 147.8,

  },
});

export default Logo;
