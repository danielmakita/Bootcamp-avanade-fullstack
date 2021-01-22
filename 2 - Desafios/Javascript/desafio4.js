var N = parseInt(gets());
var arr = [];

for(let i = 0; i<N; i++){
  let value;
  value = parseInt(gets());
  arr.push(value);
}

arr.sort(function(a,b) { /*Ordenando em ordem crescente*/ 
  return a - b;
});

var counts = {};
var values = {};

/* Percorre o array e verifica se o elemento existe no objeto, se sim soma, caso contrario inclui*/
for (let i = 0;  i<N; i++){ 
  var num = arr[i];
  counts[num] = counts[num] ? counts[num] + 1 : 1;
}

for (var [key, count] of Object.entries(counts)) {
    console.log(key + ' aparece ' + count + ' vez(es)'); 
}