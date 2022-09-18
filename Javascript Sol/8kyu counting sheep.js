function countSheeps(arrayOfSheep) {
  // TODO May the force be with you
  
  let sheep = 0;
  
  for(let i = 0; i<arrayOfSheep.length; i++)
  {
    if(arrayOfSheep[i])
    {
      sheep++;
    }
  }
  
  return sheep;
    
    
  
}