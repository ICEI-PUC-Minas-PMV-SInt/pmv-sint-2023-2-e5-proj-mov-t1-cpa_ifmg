import API from './webapi.services';
import {BASE_URL} from './urls';

export const getCampus = async () => {
  try{

    return await API.get(`${BASE_URL}/Campi`).then(
      response=>{
        return response.data;        
      },
      error => {
        console.log(error);
        return null;
      }
    );

  }catch(error){
    console.log(error)
    return null;
  }
}
export const postCampus = async (param) => {
  try{

    return await API.post(`${BASE_URL}/Campi`,param).then(
      response=>{
        return response.data;        
      },
      error => {
        console.log(error);
        return null;
      }
    );

  }catch(error){
    console.log(error)
    return null;
  }
}
export const updateCampus = async (param) => {
  try{

    return await API.put(`${BASE_URL}/Campi/${param.id}`,param).then(
      response=>{
        return response.data;        
      },
      error => {
        console.log(error);
        return null;
      }
    );

  }catch(error){
    console.log(error)
    return null;
  }
}
export const deleteCampus = async (id) => {
  try{

    return await API.delete(`${BASE_URL}/Campi/${id}`).then(
      response=>{
        return response.data;        
      },
      error => {
        console.log(error);
        return null;
      }
    );

  }catch(error){
    console.log(error)
    return null;
  }
}

