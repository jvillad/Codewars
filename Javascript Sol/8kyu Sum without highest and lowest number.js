function sumArray(array) {
  if(array === null)
    return 0;
  if(array == undefined)
    return 0;
  if(array.length <= 2)
    return 0;
  
  const minMax = Math.max(...array) + Math.min(...array);
  
   
   let count = 0;
   for(var i=0; i < array.length; i++) 
   { 
      
        count += array[i]; 
   }
  return count - minMax;
  
  //NOT AN 8 KYU. LOL
}