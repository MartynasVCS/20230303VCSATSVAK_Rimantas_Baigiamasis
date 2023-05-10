# Final-Task-DJI-store-automatic-tests

Final task for Automatinis Testavimas course of Code Academy, where several automatic tests of DJI Store were performed.

Preconditions:
1. User has opened the DJI store [https://store.dji.com/lt](https://store.dji.com/lt).
2. User has a valid account for the DJI store.
3. User is logged in to the DJI store.
4. Region settings: Lithuania (English / € EUR).

## Test Scenarios (TS)

### TS001: Search and add product to cart

- **TC001:** Search for "DJI Mini 3"
  - **TC001.01:** Click the Search icon
  - **TC001.02:** Select "DJI Mini 3" from drop-down menu
  - **TC001.03:** Verify that the relevant and containing "DJI Mini 3" product page was opened

- **TC002:** Add "DJI Mini 3" to cart
  - **TC002.01:** On the product page (https://store.dji.com/lt), click "DJI Mini 3Fly More Combo (DJI RC-N1) 658 €" option
  - **TC002.02:** Verify that the product added to the shopping bar and total price is 658 €
  - **TC002.03:** Click the button "Shop Now"
  - **TC002.04:** Click "Continue Without Coverage"
  - **TC002.05:** Verify that the message "1 Item(s) Added to Cart Successfully! DJI Mini 3 Fly More Combo (DJI RC-N1) ×1" is displayed
  - **TC002.06:** Click View Cart Checkout

### TS002: Update and remove item from cart

- **TC003:** Update "DJI Mini 3" quantity in the product cart
  - **TC003.01:** Click on the "Cart" button in the top right corner of the page. Two items in the shopping cart are listed for the total sum of 1316 €
  - **TC003.02:** Click on the "+" button next to quantity 2 of the "DJI Mini 3"
  - **TC003.03:** Verify that two items are in the the shopping cart

- **TC004:** Remove "DJI Mini 3" products from the cart
  - **TC004.01:** Click on the "Cart" button in the top right corner of the page. Product cart page (https://store.dji.com/lv/cart?from=store-nav) will open. The products removed from the shopping cart
  - **TC004.02:** Click on the "Recycle bin" icon next to "DJI Mini 3" in the shopping cart
  - **TC004.03:** Verify that the shopping cart is empty and the message "Your Shopping Cart is Empty" is displayed

### TS003: Navigate to the "Refurbished Products" category

- **TC005:** Navigate to the "Refurbished Products" category
  - **TC005.01:** Hover over the "Refurbished Products" button in the top navigation menu
  - **TC005.02:** The page [https://store.dji.com/lt/pages/refurbished?from=store-nav](https://store.dji.com/lt/pages/refurbished?from=store-nav) opens, "Camera Drones" category is active
  - **TC005.03:** Verify that the page displays relevant drone products

### TS004: Change the region, language, currency

- **TC006:** Change the region to Latvia (language to English, currency to €)
  - **TC005.01:** Click on the region button in the top right side of navigation menu
  - **TC005.02:** Select "Latvia English/ € EUR" in the Region Selection table
  - **TC005.03:** Verify that the "Latvia English/ € EUR" region is selected
