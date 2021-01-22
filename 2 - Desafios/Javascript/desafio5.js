while(true){
    var vogals = gets();
    var phrase = gets();
    
    if(vogals === '')
      break;
    
    var arrVogals = [...vogals];
    var arrPhrase = [...phrase];
    var count = 0;
    
    for(let i=0; i<arrVogals.length; i++){
      var vog = arrVogals[i];
      for(let i=0; i<arrPhrase.length; i++){
        if(vog === arrPhrase[i])
          count++;
      }
    }
    console.log(count);
  }
  