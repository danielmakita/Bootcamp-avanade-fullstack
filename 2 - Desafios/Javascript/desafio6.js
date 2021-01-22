var input = '';
var names = [];
var participants = [];
var uniqueParticipants = [];

getAllNames();
getParticipants();
printWinner();

function getAllNames(){
  while(true && input!= "FIM"){
    var input = gets();
    if(input != "Abhay SIM" && input!="FIM")
      names.push(input);
    }
    let cleanNameYes = [];
    let cleanNameNo = [];
    
    for(let n of names){
      if(n.includes('SIM'))
        cleanNameYes.push(n.slice(0, n.indexOf(" ")));
    }
      
    for(let n of names){
      if(n.includes('NAO'))
        cleanNameNo.push(n.slice(0, n.indexOf(" ")));
    }
      
    cleanNameYes.sort();
    cleanNameNo.sort();
    
    cleanNameYes = cleanNameYes.concat(cleanNameNo);
    
    uniqueAllNames = [...new Set(cleanNameYes)];
    
    // Descomentar linhas abaixo para a submissao final
    for(let n of uniqueAllNames)
      console.log(n);
}

function getParticipants(){
  for(let name of names){
    if(name.includes('SIM'))
      participants.push(name.slice(0, name.indexOf(" ")));
  }
  
  uniqueParticipants = [...new Set(participants)];
}

function printWinner(){
    var max = 0;
    var winnerName = '';
    for(let winner of uniqueParticipants){
      if(max < winner.length){
        max = winner.length;
        winnerName = winner;
      }
    }
    console.log();
    console.log('Amigo do Pablo: ');
    console.log(winnerName);
}