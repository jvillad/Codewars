function betterThanAverage(classPoints, yourPoints) {
  
  let avg = 0;
  
  for(let i = 0; i< classPoints.length; i++){
    
    avg += classPoints[i];    
    
  }
  
  avg = avg/classPoints.length;
  
  if(avg < yourPoints)
    return true;
  
  if(avg > yourPoints)
    return false;
  
  
  
}