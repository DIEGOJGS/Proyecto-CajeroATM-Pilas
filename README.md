# 🏧 Proyecto CajeroATM - Simulación de Pila (Stack)

Este proyecto es una aplicación de Windows Forms (C#) que simula el historial de transacciones de un cajero automático. Su objetivo principal es demostrar el uso y los principios de la estructura de datos **Pila (Stack)**.

Partiendo de una base, se implementaron múltiples mejoras funcionales y conceptuales para crear una simulación más robusta, profesional y teóricamente correcta.

---

## 🚀 Mejoras Implementadas

* **Cálculo de Saldo Realista:**
    * Se implementó un **`_saldoInicial`** (ej. S/. 1,000) para que la cuenta no empiece en cero.
    * El saldo se calcula en tiempo real (`_pila.CalcularSaldo()`) y se muestra en la interfaz.

* **Interfaz de Registro Robusta:**
    * Se reemplazó un `TextBox` de descripción genérico por un `ComboBox` de **Tipo** (`Depósito`, `Retiro`, `Pago`, etc.) y un `TextBox` de **Detalle** (opcional).
    * **Beneficio:** Esto estandariza la entrada de datos, previene errores del usuario y asegura que la lógica de cálculo de saldo sea 100% confiable.

* **Implementación Correcta de `Pop` (Anular Última):**
    * Se agregó el botón **"Anular Última"**.
    * Este botón implementa la operación `Pop` pura de la Pila: elimina **únicamente** la transacción más reciente que está en la cima (`_tope`).

* **Lógica Profesional de "Extorno" (Anular Seleccionado):**
    * Se agregó el botón **"Anular Seleccionado"** para manejar errores en transacciones pasadas.
    * Esta función **no borra** transacciones (respetando la lógica de Pila y contabilidad).
    * En su lugar, crea una **nueva transacción opuesta** (`Push`) para corregir el saldo, incluyendo el detalle de la operación que anula.

---

## 🧠 Concepto Clave: Por qué NO se "elimina" cualquier ítem

En el desarrollo de este proyecto, se determinó que "eliminar un ítem seleccionado al azar" era incorrecto por dos razones fundamentales:

### 1. La Regla de la Estructura de Datos (Pila)
Una **Pila (Stack)** se define por su principio **LIFO (Last In, First Out)**. En una Pila, solo se tiene acceso al elemento de la cima (`_tope`). Eliminar un elemento del medio viola esta regla fundamental y demuestra una incomprensión de la estructura de datos.

### 2. La Regla de Negocio (Cajero ATM)
En un sistema financiero real, las transacciones **NUNCA se borran**. Un historial bancario es un registro contable **inmutable** que sirve como rastro de auditoría. No se puede simplemente borrar un pago.

## ✅ La Solución Correcta: Anulación vs. Extorno

Para resolver los errores de forma profesional y respetando las reglas, se implementaron dos botones:

1.  **`Anular Última` (Operación `Pop`):**
    * Representa la operación `Pop` de la Pila. Se usa para deshacer la *última* acción de inmediato.

2.  **`Anular Seleccionado` (Operación de Corrección):**
    * Esta es la lógica de negocio correcta. No borra nada.
    * Genera una **transacción opuesta** para revertir el efecto de un error pasado y la añade a la cima de la Pila (`Push`).
    * **Si se anula un `Depósito` (error de ingreso):** Se crea un `Retiro` para restar el monto.
    * **Si se anula un `Pago` o `Retiro` (error de egreso):** Se crea un `Depósito` (Extorno) para devolver el monto.
    * La nueva transacción (ej. "Extorno de Pago") incluye el detalle de la operación original (ej. "(Servicio de Luz)") para mantener un historial claro.
