import React from "react"
import styles from "./Add.module.scss"
import TextInput from "../TextInput/TextInput";
import UnsetButton from "../UnsetButton/UnsetButton";
import axios from "axios";

export default function Add() {
    const [ingredients, setIngredients] = React.useState([]);
    const [value, setValue] = React.useState("");
    const [select, setSelect] = React.useState('1')
    const [inputValue, setInputValue] = React.useState('')

    const changeIngredientInput = (event) => {
        setValue(event.target.value);
    };

    function handleIngredient() {
        const valueTrim = value.trim()
        if (valueTrim) {
            setIngredients([...ingredients, valueTrim])
            setValue('');
        }
    }

    const onRemoveIngredient = (index) => {
        setIngredients(currentIngredients => currentIngredients.filter((_, i) => i !== index));
    }
    const handleChange = (event) => {
        setInputValue(event.target.value)
    }
    const handleIco = (event) => {
        setSelect(event.target.value)
    }
    const changeIco = () => {
        switch (select) {
            case "1":
                return "img/all-cocktails/cocktail1.png"
            case "2":
                return "img/all-cocktails/cocktail2.png"
            case "3":
                return "img/all-cocktails/cocktail3.png"
            case "4":
                return "img/all-cocktails/cocktail4.png"
            case "5":
                return "img/all-cocktails/cocktail5.png"
            case "6":
                return "img/all-cocktails/cocktail6.png"
            case "7":
                return "img/all-cocktails/cocktail7.png"
            case "8":
                return "img/all-cocktails/cocktail8.png"
        }
    }
    const onDeleteText = () => {
        setInputValue('')
    }
    const onSecondDeleteText = () => {
        setValue('')
    }
    const onAddCocktail = () => {
    }
    return (
        <section className={styles.name}>
            <div className={styles.name__up}>
                <h2>Add A Cocktail</h2>
                <div className={styles.name__name}>
                    <h3>Name:</h3>
                    <TextInput onClick={onDeleteText} value={inputValue} onChange={handleChange} placeholder = "Name of the new cocktail" />
                    <UnsetButton onClick = {onAddCocktail} text="Add" />
                </div>
            </div>
            <div className={styles.name__main}>
                <div className={styles.name__upcontainer}>
                    <div className={styles.name__ingredients}>
                        <h2>Ingredients:</h2>
                        <TextInput onChange={changeIngredientInput} onClick={onSecondDeleteText} value={value} type="text" placeholder="Enter cocktail's ingredients..." />
                        <div className={styles.name__list}>
                            {ingredients.map((ingredient, index) => (
                                <div key={index} className={styles.name__item}>
                                    <p>- {ingredient}</p>
                                    <UnsetButton text="&#x2716;" onClick={() => onRemoveIngredient(index)} />
                                </div>
                            ))}
                        </div>
                        <UnsetButton onClick={handleIngredient} text="Add"/>
                    </div>
                    <div className={styles.name__containerico}>
                        <div className={styles.name__mainico}>
                            <img src={changeIco()} alt="ico" />
                        </div>
                        <select onChange={handleIco}>
                            <option value="1">Sand Yellow</option>
                            <option value="2">Soft Blue</option>
                            <option value="3">Cold Rose</option>
                            <option value="4">Forest Green</option>
                            <option value="5">Orange sun</option>
                            <option value="6">Blue Eye</option>
                            <option value="7">Floral yellow</option>
                            <option value="8">Glass Blue</option>
                        </select>
                    </div>
                </div>
                <div className={styles.name__about}>
                    <textarea placeholder="Enter your cocktail information..." cols="80" rows="5" spellCheck="false"></textarea>
                </div>
            </div>
        </section>
    );
}
