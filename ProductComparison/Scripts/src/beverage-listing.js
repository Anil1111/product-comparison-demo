document.addEventListener('DOMContentLoaded', () => {
    var beverageListing = new Vue({
        el: '#beverage-listing',
        data: {
            beverages: null
        },
        mounted() {
            this.loadBeverages();
        },
        methods: {
            isCompareDisabledForSku(sku) {
                var skuIsDisabled = false;

                if (sku !== undefined) {
                    var skuIsInCompare = window.compare.skuIsInCompare(sku);

                    if (!skuIsInCompare && window.compare.isFull()) {
                        skuIsDisabled = true;
                    }
                } else {
                    skuIsDisabled = window.compare.isFull();
                }

                return skuIsDisabled;
            },
            isCompareCheckedForSku(sku) {
                var skuIsChecked = false;

                if (sku !== undefined) {
                    var skuIsInCompare = window.compare.skuIsInCompare(sku);

                    if (skuIsInCompare) {
                        skuIsChecked = true;
                    }
                }

                return skuIsChecked;
            },
            isMultipleOfThree(number) {
                return (number) % 3 === 0;
            },
            loadBeverages() {
                this.$http.get("/api/beverage-listing/all")
                    .then(response => {
                        this.beverages = response.data.Beverages;
                        this.beverages = this.beverages.sort(compare);
                    })
                    .catch((error) => {
                        console.log(error);
                    });
            },
            toggleCompare(event) {
                var checked = event.target.checked;
                var sku = event.target.name;
                if (checked) {
                    window.compare.addProduct(sku);
                } else {
                    window.compare.removeProduct(sku);
                }
            }
        }
    });

    function compare(a, b) {
        var skuA = a.Sku.toUpperCase();
        var skuB = b.Sku.toUpperCase();

        var comparison = 0;
        if (skuA > skuB) {
            comparison = 1;
        } else if (skuA < skuB) {
            comparison = -1;
        }
        return comparison;
    }
});