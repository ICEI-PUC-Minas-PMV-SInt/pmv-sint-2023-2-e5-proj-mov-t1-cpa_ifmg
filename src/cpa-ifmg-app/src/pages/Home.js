import React,{useState} from 'react';
import { BottomNavigation, Menu } from 'react-native-paper';
import { View } from 'react-native';

import Cursos from './Cursos';
import Proposta from './Proposta';
import Melhoria from './Melhoria';
import Cronograma from './Cronograma';
import Membros from './Membros';
import Metas from './Metas';


const Home = () => {
  const [index, setIndex] = useState(0);
  const [routes] = React.useState([
    { key: 'proposta', title: 'Proposta', icon:'file-document-outline'},
    { key: 'melhoria', title: 'Melhoria', icon:'head-lightbulb-outline'},
    { key: 'cronograma', title: 'Cronograma', icon:'calendar-check-outline'},
    { key: 'cursos', title: 'Cursos', icon:'file-certificate-outline'},
    { key: 'membros', title: 'Membros', icon:'account-group'},
    { key: 'metas', title: 'Metas', icon:'target'}
    
  ]);

  const renderScene = BottomNavigation.SceneMap({
    proposta: Proposta,
    melhoria: Melhoria,
    cronograma:Cronograma,
    cursos:Cursos,
    membros:Membros,
    metas:Metas,
    
  });
  

  return (
    <BottomNavigation
      navigationState={{ index, routes }}
      onIndexChange={setIndex}
      renderScene={renderScene}
      barStyle={{ backgroundColor: '#2f9e41' }}
      
    />
    
  );
};

export default Home;