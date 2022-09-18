function updateLight(current) {
  
  let light = '';
  if(current === "green")
    light = "yellow";
  if(current === "yellow")
    light = "red";
  if(current === "red")
    light = "green";
  
  return light;
  
  
  

}