function points(games) {
  let points = 0;
  for(let i = 0; i<games.length; i++){
    if(games[i].substr(0,1) > games[i].substr(2)){
      points += 3;
    }
    else if (games[i].substr(0,1) < games[i].substr(2)){
      continue;
    }
    
    if(games[i].substr(0,1) == games[i].substr(2)){
      points += 1;
    }
    
    
    
  }
  return points;
  
  
}