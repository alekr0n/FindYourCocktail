import styles from "./Name.module.scss"
import TextInput from "../TextInput/TextInput"
import React from "react"
import UnsetButton from "../UnsetButton/UnsetButton"
import Card from "../Card/Card"
import axios from "axios"
import NameModal from "../NameModal/NameModal"

export default function Name() {
    const [inputValue, setInputValue] = React.useState('')
    const [allCocktails, setAllCocktails] = React.useState([])
    const [modal, setModal] = React.useState()
    const [object, setObject] = React.useState({})


    const handleChange = (event) => {
        setInputValue(event.target.value)
    }
    const onDeleteText = () => {
        setInputValue('')
    }
    React.useEffect(() => {
        axios.get('/allCocktails.json').then((res) => {
            setAllCocktails(res.data)
        })
    },[])

    const  onClickModal = () => {
        setModal(!modal)
    }

    const onClickCard = (key) => {
        setObject({name: key.name, img: key.img, ingredients: key.ingredients})
        console.log(key);
        onClickModal()
    }

    return (
        <section className={styles.name}>
            <div className={styles.name__up}>
                <h2>Search By: {inputValue}</h2>
                <nav className={styles.name__menu}>
                    <ul>    
                        <li>
                            <TextInput
                            placeholder="Enter cocktail's name"
                            onChange = {handleChange}
                            value={inputValue}
                            onClick={onDeleteText}
                            />
                        </li>
                        <li><UnsetButton text="Find" /></li>
                    </ul>
                </nav>
            </div>
            <div className={styles.name__main}>
                {allCocktails.filter(item => item.name.toLowerCase().includes(inputValue.toLowerCase())).map((obj) => {
                    return (
                            <Card
                            onClick={() => onClickCard({name: obj.name, img: obj.img, ingredients: obj.ingredients})}
                            key={obj.name}
                            name={obj.name}
                            img={obj.img}
                            ingredients={obj.ingredients}
                            />
                    )
                })}
            </div>
            {modal && (

                <NameModal object ={object} onClickModal={onClickModal} />

            ) }
        </section>
    )
}