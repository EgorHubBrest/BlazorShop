redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51OSdb3EH5pmvUNfebs01kycwdJVtbsvV1Eb5jA8GSFhoKo2sJZvniflrHzKoQJXZ3doEcicjNwS6VisOZ4Xi5FNr00XmpFTX07");
    stripe.redirectToCheckout({ sessionId: sessionId });
}