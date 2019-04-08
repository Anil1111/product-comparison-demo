Array.prototype.remove = function (key, value) {
    var index = this.findIndex(obj => obj[key] === value);
    return index >= 0 ? [
        ...this.slice(0, index),
        ...this.slice(index + 1)
    ] : this;
};

window.compare = new Vue({
    el: '#compare-pop-up',
    data: {
        selectedProducts: []
    },
    mounted: function () {
        var storageProducts = JSON.parse(window.localStorage.getItem('productCompareList'));
        if (storageProducts != null) {
            this.selectedProducts = storageProducts;
        }
    },
    methods: {
        addProduct: function (sku) {
            if (this.selectedProducts.filter(e => e.sku === sku).length > 0 || this.selectedProducts.length > 3) {
                return;
            }

            this.$http.get(`/api/compare/beverage?sku=${sku}`)
                .then(response => {
                    var product = response.data;
                    this.selectedProducts.push({
                        marketing_name: product.MarketingName,
                        sku: product.Sku,
                        thumb: product.Thumbnail
                    });
                })
                .catch((error) => {
                    console.log(error);
                });

            window.localStorage.setItem('productCompareList', JSON.stringify(this.selectedProducts));
        },
        removeProduct: function (sku) {
            this.selectedProducts = this.selectedProducts.remove("sku", sku);
        },
        isFull: function () {
            var isFull = true;
            if (this.selectedProducts.length < 4) {
                isFull = false;
            }

            return isFull;
        },
        skuIsInCompare: function (sku) {
            var isInCompare = this.selectedProducts.filter(e => e.sku === sku).length > 0;
            return isInCompare;
        }
    },
    computed: {
        selectedProductsQueryString: function () {
            return "?skus=" + this.selectedProducts.map(x => x.sku).join('&skus=');
        }
    },
    watch: {
        selectedProducts: function () {
            window.localStorage.setItem('productCompareList', JSON.stringify(this.selectedProducts));

            var skuList = [];
            this.selectedProducts.forEach(function (product) {
                skuList.push(product.sku);
            });
        }
    }
}); 