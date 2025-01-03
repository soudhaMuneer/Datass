

document.addEventListener('DOMContentLoaded', function() {
    var items = [
        { name: "shirt", image: "image/image 5.png", description: "2 years", price: "1400" },
        { name: "shirt", image: "./image/dress-shirt-img.png", description: "2 years", price: "2400" },
        { name: "shirt", image: "./image/image 6.png", description: "4 years", price: "1100" },
        { name: "shirt", image: "./image/image 8.png", description: "4 years", price: "1100" },
        { name: "shirt", image: "./image/image 9.png", description: "4 years", price: "1100" },
        { name: "frock", image: "./image/women-clothes-img.png", description: "4 years", price: "1100" }
    ];

    var cart = []; // Initialize the cart array

    listItems();

    function listItems() {
        var content = document.getElementById('content');
        content.innerHTML = '';  // Clear any existing content

        items.forEach(item => {
            var colDiv = document.createElement('div');
            colDiv.classList.add('col-4', 'mb-4'); // 'mb-4' for spacing between rows

            var cardDiv = document.createElement('div');
            cardDiv.classList.add('card', 'h-70', 'w-170');

            var image = document.createElement('img');
            image.src = item.image;
            image.classList.add('card-img-top');
            image.alt = item.name;

            var cardBody = document.createElement('div');
            cardBody.classList.add('card-body');

            var name = document.createElement('h5');
            name.classList.add('card-title');
            name.textContent = item.name;

            var description = document.createElement('p');
            description.classList.add('card-text');
            description.textContent = item.description;

            var price = document.createElement('p');
            price.classList.add('card-text');
            price.textContent = `Price: $${item.price}`;

            var button = document.createElement('button');
            button.classList.add('btn', 'btn-danger');
            button.textContent = 'Add to cart';

            button.addEventListener('click', function() {
                addToCart(item);
                cartShow();
            });

            cardBody.appendChild(name);
            cardBody.appendChild(description);
            cardBody.appendChild(price);
            cardBody.appendChild(button);

            cardDiv.appendChild(image);
            cardDiv.appendChild(cardBody);

            colDiv.appendChild(cardDiv);

            content.appendChild(colDiv);
        });
    }

    function cartShow() {
        var circle = document.querySelector('.circle p');
        circle.textContent = cart.length;  // Update the circle with the cart length
    }

    function addToCart(item) {
        cart.push(item);
        alert('Item added successfully!');
        console.log(cart); // Display the cart in the console for debugging
    }

   
   
window.onscroll = function() {myFunction()};

// Get the header
var header = document.getElementById("myHeader");

// Get the offset position of the navbar
var sticky = header.offsetTop;

// Add the sticky class to the header when you reach its scroll position. Remove "sticky" when you leave the scroll position
function myFunction() {
  if (window.pageYOffset > sticky) {
    header.classList.add("sticky");
  } else {
    header.classList.remove("sticky");
  }
}
});

