import * as React from 'react';
import { Button } from 'react-native-paper';
import Header from '../components/Header';
import Container from '../components/Container';
import Body from '../components/Body';
import CustomButton from '../components/CustomButton';
import {useNavigation} from '@react-navigation/native';
import { StyleSheet,View,Text} from 'react-native';

const Inicio = () => {
  const navigation=useNavigation();
  return(
    <Container>
      <Header title={'Nova Proposta'}></Header>
      <Body>
        <View style={styles.secao}>
        <Button style={styles.button} color={'#2f9e41'} mode="contained" onPress={()=> navigation.navigate('Melhoria')}>
       <Text style={styles.buttonText}>Propostas de Melhoria</Text>
        </Button>
        <Button style={styles.button} color={'#2f9e41'} mode="contained" onPress={()=> navigation.navigate('Cronograma')}>
        <Text style={styles.buttonText}>Cronograma</Text>
        </Button>
        </View>
        
        <View style={styles.secao}>
          <Button style={styles.button} color={'#2f9e41'} mode="contained" onPress={()=> navigation.navigate('Cursos')}>
          <Text style={styles.buttonText}> Cursos </Text>
          </Button>
        </View>
        <View style={styles.secao}>
        <Button style={styles.button} color={'#2f9e41'} mode="contained" onPress={()=> navigation.navigate('Membros')}>
        <Text style={styles.buttonText}> Membros </Text>
        </Button>
        <Button style={styles.button} color={'#2f9e41'} mode="contained" onPress={()=> navigation.navigate('Metas')}>
        <Text style={styles.buttonText}>Metas</Text>
        </Button>
        
        </View>
        
      
      </Body>
    </Container>
  );
  
 
};
const styles=StyleSheet.create({
  
  button:{
   
    margin:20,
    
    width:130,
    height:130,
    justifyContent: 'center', 
    alignItems: 'center',     
    
},
buttonText: {
  color: 'white',
  fontSize: 14,
  fontWeight: 'bold',
  textAlign: 'center', // alinha o texto no centro
},
  secao:{
    flex:1,
    flexDirection:'row',
    marginTop:8,
    marginBottom:8,
    justifyContent: 'center',
    alignItems: 'center'
    
    
    

  }
});

export default Inicio;
