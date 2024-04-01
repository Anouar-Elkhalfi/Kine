 // Empêcher la sélection de dates antérieures
 const ant = document.getElementById("date").min = new Date().toISOString().split("T")[0];
 console.log(ant);

 const ant = document.getElementById("date").min = new Date().toISOString().split("T")[0];
 console.log(ant);
const scriptURL = 'https://script.google.com/macros/s/AKfycbwBhWe7975ua2BeGY0h5S-HHha0Fj8HKU_fbA2bwbrkDI6AKIWwb2018eX5oAU96Hbdkw/exec'
const form = document.forms['submit-to-google-sheet']

form.addEventListener('submit', e => {
 e.preventDefault()
 fetch(scriptURL, { method: 'POST', body: new FormData(form)})
   .then(response => console.log('Success!', response))
   .catch(error => console.error('Error!', error.message))
})

// reset du formulaires
document.querySelector("form[name='submit-to-google-sheet']").addEventListener("submit", function(event) {
 event.preventDefault(); // Empêche la soumission par défaut du formulaire
 // Réinitialise le formulaire
 document.querySelector("form[name='submit-to-google-sheet']").reset();
 // Affiche le message de confirmation
 document.getElementById("msg").style.display = "block";
 // Masque le message de confirmation après 3 secondes
 setTimeout(function() {
     document.getElementById("msg").style.display = "none";
 }, 5000);
});
