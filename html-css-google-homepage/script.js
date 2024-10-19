
// Camera upload script

document.getElementById('camera-button').addEventListener('click', function () {
    document.getElementById('image-upload').click();
});

document.getElementById('image-upload').addEventListener('change', function (event) {
    const file = event.target.files[0];
    if (file) {
        const reader = new FileReader();

        reader.onload = function (e) {

            window.open(`https://www.google.com/searchbyimage?image_url=${e.target.result}`, '_blank');
        };

        reader.readAsDataURL(file);
    }
});


//Microphone search script

document.addEventListener('DOMContentLoaded', () => {
    const micButton = document.querySelector('.mic-button');
    const searchBar = document.getElementById('search-bar');
    const form = searchBar.closest('form');

    if ('webkitSpeechRecognition' in window) {
        const recognition = new webkitSpeechRecognition();
        recognition.continuous = false;
        recognition.interimResults = false;
        recognition.lang = 'en-US';

        micButton.addEventListener('click', () => {
            console.log('Microphone button clicked');
            recognition.start();
        });

        recognition.onresult = (event) => {
            console.log('onresult triggered');
            if (event.results.length > 0 && event.results[0].isFinal) {
                const transcript = event.results[0][0].transcript;
                console.log('Voice input:', transcript);
                searchBar.value = transcript; 
                searchBar.focus();
                searchBar.select();
            } else {
                console.log('No final results found.');
            }
            // Stop recognition here if desired
            recognition.stop();
        };
        
        

        recognition.onend = () => {
            console.log('Speech recognition has ended.');
            // Optional: You can restart recognition if desired
        };

        recognition.onerror = (event) => {
            console.error('Error occurred in recognition:', event.error);
            recognition.stop(); // Ensure recognition stops on error
        };
    } else {
        console.log('Speech recognition not supported in this browser.');
    }

    form.addEventListener('submit', (event) => {
        event.preventDefault(); 
        console.log('Form submitted:', searchBar.value); 
       
        window.location.href = `https://www.google.com/search?q=${encodeURIComponent(searchBar.value)}`;
    });

    recognition.onstart = () => {
        console.log('Speech recognition started');
    };
    
    recognition.onend = () => {
        console.log('Speech recognition has ended.');
    };
    
    recognition.onerror = (event) => {
        console.error('Error occurred in recognition:', event.error);
    };
    
});

