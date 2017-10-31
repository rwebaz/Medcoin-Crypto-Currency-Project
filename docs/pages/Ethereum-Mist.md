---
title: Ethereum Mist
layout: default
navigation_weight: 4
---
# Ethereum Mist

**Mist** is the official Ethereum crypto currency Operating wallet.

{% include md-toc-medcoin-gold.htm %}

## Aleth Zero

**Aleth Zero** is an implementation of Ethereum for developers that has been written in C++

## Solidity

**Solidity** is a backend ( contract ) language eligible for conversion into the low level language of the Etherium Virtual Machine, or EVM.

The EVM compiler takes the Solidity code and converts it to a machine language format eligible to be read and executed by the EVM.

A basic contract is formed, as follows:

```liquid
{% raw %}
contract metaCoin {
  // The contract logic goes here
}
{% endraw %}
```

; Where the term 'metaCoin' in camel case is simultaneously both the name of the contract and the name of the primary constructor method.

## Primary Constructor Method

The **Primary Constructor Method** of a contract ( back end ) defines the initial state of the data storage of the contract.

Next, the progression of the contract steps leads to the secondary constructor method(s).

There is no "hoisting" in a Solidity contract.

Just follow along with the code.

### Map This

The first step in expressing the **Primary Constructor Method** is to set a "mapping" to storage where data can be written.

For example, a key-value pair can be set up to store coin balances in number of units.

The "key" shall be the unique address of the store, and the "value" shall be the number of coins of type integer.

In Solidity code, it look-a like this ...

```liquid
{% raw %}
contract metaCoin {
  mapping(address => uint) balances;
}
{% endraw %}
```

**Note**. Similar to the Typescript language, Solidity requires static type checking at compile time.

No wild and wholly self-interpretation a-la pure Javascript.

The type must be expressed in the code at the point of variable initialization.

There are two benefits to a strongly typed block of Solidity code ...

1. the size of the data array passed is reduced, and

1. the compiler can create even more optimized machine code for the EVM to chew on.

### Functions

Functions may be placed within the **Primary Constructor Method**, as well.

Here, in addition to the mapping code, a function is set to look up the address of the entity responsible for sending the transaction.

The transaction is to be sent to a mining node within the Ethereum network.

Secondly, the function taps the storage of the now mapped balances, as follows:

```liquid
{% raw %}
contract metaCoin {
  mapping(address => uint) balances;

  function metaCoin() {
    balances[msg.sender] = 10000;
  }
}
{% endraw %}
```

; where the **Primary Constructor Method** ( initialization function ) is run once, and only once.

## Secondary Constructor Method(s)

The **Secondary Constructor Method(s)** get written to the block chain under separate immutable addresses.

In this case, we are constructing a 'sendCoin' function as a **Secondary Constructor Method**.

Each and every time the back end ( contract ) is called in the future, only the **Secondary Constructor Method(s)** will execute as we have already initialized the contract one time previously.

And, yes ... Even though we have used the name 'metaCoin' for both the **Primary Constructor Method** and the name of the back end ( contract ), we may also use the name 'metaCoin' a 3rd time inside the **Secondary Constructor Method**.

The Solidity code for the 'sendCoin' function look-a like this ... Notice the first function is named 'metaCoin'.

### Send Coin Now

Contract for sending coin from a Sender's account to a Receiver's account ...

```liquid
{% raw %}
contract metaCoin {
  mapping(address => uint) balances;

  function metaCoin() {
    balances[msg.sender] = 10000;
  }

  function sendCoin(address receiver, uint amount) returns(bool sufficient) {
    if (balances[msg.sender] < amount) return false;
    balances[msg.sender] -= amount;
    balances[receiver] += amount;
    return true;
  }
}
{% endraw %}
```

## Fill 'Er Up

"Fill 'er up with **Ether**, please!" ~ Modern 21st Century Miner

Your friendly neighborhood Ethereum miner sits at his or her node all day waiting for an opportunity to mix a block or two.

They've invested computing power and they must pay for the electricity to run their own personal "coin farm".

How do they get paid?

Are they performing a service that justifies a payment?

**Answer**. The parties to the contract negotiate which party, or both in like percentage, or at some other sharing arrangement ...

Who gets to pay the Miner for reconciling the transaction and for writing the result of the transaction to the immutable block chain.

Any takers?

{% include sources-and-uses.md %}

### External Sources

- [Project Source Links](https://rwebaz.github.io/Medcoin-Crypto-Currency-Project/pages/Source-Links.html){:title="Click to Visit the Medcoin™ Crypto Currency Project Source Links Page"}{:target="_blank"). Published by © 2017 [Mminail.github.io](https://mminail.github.io/){:title="Click to Visit the Concept Library of the Medical Marijuana Initiative of North America - International Limited, an Arizona Benefit Corporation"}{:target="_blank"}.

- [Block Chain: Understanding Financial Technology by Charles Jensen](https://www.amazon.com/){:title="Click to Visit Block Chain: Understanding Financial Technology by Charles Jensen at Amazon"}{:target="_blank"). Self-published by © 2017 [Charles Jensen](https://www.amazon.com/){:title="Click to Visit Block Chain: Understanding Financial Technology by Charles Jensen at Amazon"}{:target="_blank"}.
